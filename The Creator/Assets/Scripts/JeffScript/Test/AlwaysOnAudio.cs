using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysOnAudio : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
