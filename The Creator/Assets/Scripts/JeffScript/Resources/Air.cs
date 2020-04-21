using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Air : MonoBehaviour
{
    public AirCount evolutionManager;
    private void OnCollisionEnter(Collision collision)
    {
        AirCount.airCount += 1;
        Destroy(gameObject);
    }
}
