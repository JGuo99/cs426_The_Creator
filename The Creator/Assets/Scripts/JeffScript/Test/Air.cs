using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Air : MonoBehaviour
{
    public AirCount evolutionManager;
    private void OnCollisionEnter(Collision collision)
    {
        AirCount.airCount += 2;
        Destroy(gameObject);
    }
}
