using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinding : MonoBehaviour
{
    [SerializeField]
    float movementSpeed = 5.0f; //Speed the ship is flying
    [SerializeField]
    Transform target;
    [SerializeField]
    float rotateSmooth = 0.5f;

    //The Detection Length are all different so 
    //it can prevent two sides from touching at the same time.
    [SerializeField]
    float detectionUp = 2f;
    [SerializeField]
    float detectionDown = 1.75f;
    [SerializeField]
    float detectionLeft = 1.25f;
    [SerializeField]
    float detectionRight = 1.5f;

    [SerializeField]
    float rayCastOffSet = .5f;

    private void Update()
    {
        PathFinder();
        Move();
    }

    void Move()
    {
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }

    void Turn()
    {
        Vector3 position = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotateSmooth * Time.deltaTime);
    }

    void PathFinder()
    {
        RaycastHit rayCollide;
        Vector3 rayOffset = Vector3.zero;
        Vector3 left = transform.position - transform.right * rayCastOffSet;
        Vector3 right = transform.position + transform.right * rayCastOffSet;
        Vector3 down = transform.position - transform.up * rayCastOffSet;
        Vector3 up = transform.position + transform.up * rayCastOffSet;

        //Debugging Purposes: To see the Rays Lines
        Debug.DrawRay(left, transform.forward * detectionLeft, Color.cyan);
        Debug.DrawRay(right, transform.forward * detectionRight, Color.cyan);
        Debug.DrawRay(up, transform.forward * detectionUp, Color.cyan);
        Debug.DrawRay(down, transform.forward * detectionDown, Color.cyan);

        if(Physics.Raycast(left, transform.forward, out rayCollide, detectionLeft)) {
            rayOffset += Vector3.right;
        }else if (Physics.Raycast(right, transform.forward, out rayCollide, detectionRight)) {
            rayOffset -= Vector3.right;
        }

        if (Physics.Raycast(up, transform.forward, out rayCollide, detectionUp)) {
            rayOffset -= Vector3.up;
        } else if (Physics.Raycast(down, transform.forward, out rayCollide, detectionDown)) {
            rayOffset += Vector3.up;
        }

        if(rayOffset != Vector3.zero)
        {
            transform.Rotate(rayOffset * 10f * Time.deltaTime);
        }
        else
        {
            Turn();
        }
    }
}
