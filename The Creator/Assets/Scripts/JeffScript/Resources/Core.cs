using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    public CoreCount evolutionManager;
    private void OnCollisionEnter(Collision collision)
    {
        CoreCount.coreCount += 1;
        Destroy(gameObject);
    }
}
