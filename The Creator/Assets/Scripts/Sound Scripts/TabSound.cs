﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabSound : MonoBehaviour
{
    public AudioClip tabSound;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            audioSource.PlayOneShot(tabSound, .2f);
        }
    }
}
