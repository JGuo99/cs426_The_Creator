using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public WaterCount evolutionManager;
    private void OnCollisionEnter(Collision collision)
    {
        WaterCount.waterCount += 1;
        Destroy(gameObject);
    }
}
