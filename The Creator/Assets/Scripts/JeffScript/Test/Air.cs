using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Air : MonoBehaviour
{
    public AirCount evolutionManager;
    /*public GameObject instantiatedObj;
    GameObject instantiateClone;
    private void Start()
    {
        instantiateClone = Instantiate(instantiatedObj, transform.position, Quaternion.identity) as GameObject;
    }*/

    private void OnCollisionEnter(Collision collision)
    {
        AirCount.airCount += 1;
        //GameObject obj = Instantiate(instantiatedObj);
        Destroy(gameObject);
        //Destroy(instantiateClone);
    }
}
