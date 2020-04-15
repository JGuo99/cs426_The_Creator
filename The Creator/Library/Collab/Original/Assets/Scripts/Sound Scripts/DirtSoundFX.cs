using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtSoundFX : MonoBehaviour
{
    public AudioClip dirtSound;
    public AudioSource audioSource;
    //public AudioSource dirtSound;
    

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
        if (collision.gameObject.tag == "DirtRes")
        {
            Debug.Log("Dirt Collected");
            //dirtSound.Play();
            audioSource.PlayOneShot(dirtSound, .25f);
            //audioSource.Play();
        }
    }
}
