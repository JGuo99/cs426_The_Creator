using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iron : MonoBehaviour
{
    public IronCount evolutionManager;
    private void OnCollisionEnter(Collision collision)
    {
        IronCount.ironCount += 1;
        Destroy(gameObject);
    }
}
