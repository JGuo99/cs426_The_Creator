using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOPathfinding : MonoBehaviour{
    public Transform[] target;
    public float speed;

    private int currNode;

    // Update is called once per frame
    void Update(){

        if(Vector3.Distance(transform.position, target[currNode].position) > .1f) { 
            Vector3 pos = Vector3.MoveTowards(transform.position, target[currNode].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        } else {
            currNode = (++currNode) % target.Length;
        }
    }
}
