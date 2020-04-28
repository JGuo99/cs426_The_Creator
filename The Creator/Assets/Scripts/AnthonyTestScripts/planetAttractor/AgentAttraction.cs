using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentAttraction : MonoBehaviour
{
    [SerializeField] Attractor objectAttractor;
    private Transform playerTransform;

    void Start(){

        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        playerTransform = transform;
    }

    // Update is called once per frame
    void Update(){

        if (objectAttractor) {
            objectAttractor.Attract(playerTransform);
        }
    }
}
