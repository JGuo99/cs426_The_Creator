using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evolution : MonoBehaviour
{
    public Texture[] textures; //Dynamically add planet texture
    public int currentTexture;
    //public Renderer rend;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            currentTexture++;
            currentTexture %= textures.Length; //Prevent it from going out of bound.
            GetComponent<Renderer>().material.mainTexture = textures[currentTexture];
        }
    }
}
