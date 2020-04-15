using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructionSound : MonoBehaviour
{
    public AudioClip airSound;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift)){
            audioSource.PlayOneShot(airSound, 1f);
        }
    }
}
