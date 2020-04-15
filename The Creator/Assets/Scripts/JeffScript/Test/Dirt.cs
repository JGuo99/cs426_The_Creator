using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour
{
    public DirtCount resourceManager;
    private void OnCollisionEnter(Collision collision)
    {
       
        DirtCount.dirtCount += 1;
        Destroy(gameObject);
    }
}
