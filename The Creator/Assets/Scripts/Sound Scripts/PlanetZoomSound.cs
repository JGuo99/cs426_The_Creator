using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetZoomSound : MonoBehaviour
{
    public AudioClip zoomSound;
    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "StarTag" || hit.transform.tag == "GasTag" ||
                    hit.transform.tag == "TerraTag" || hit.transform.tag == "LavaTag" ||
                    hit.transform.tag == "CometTag")
                {
                    audioSource.PlayOneShot(zoomSound, 1f);
                }
            }
        }
    }

}
