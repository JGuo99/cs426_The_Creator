using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirSoundFX : MonoBehaviour
{
    public AudioClip airSound;
    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //dirtSound = audioSource.a
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "AirEvo")
        {
            Debug.Log("Air Collected");
            audioSource.PlayOneShot(airSound, .1f);
        }
    }
}
