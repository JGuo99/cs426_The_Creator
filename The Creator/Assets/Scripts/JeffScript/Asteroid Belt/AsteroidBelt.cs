using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBelt : MonoBehaviour
{
    //This allows you to see in unity editor but can't edit (Good for debugging)
    [SerializeField] 
    private float orbitSpeed;
    [SerializeField]
    private GameObject parent;
    [SerializeField]
    private bool rotationClockwise; //Clockwise
    [SerializeField]
    private float rotationSpeed;
    [SerializeField]
    private Vector3 rotationDirection;

    public void SetupAsteroidBelt(float _speed, float _rotationSpeed, GameObject _parent, bool _rotationClockwise) {
        orbitSpeed = _speed;
        parent = _parent;
        rotationClockwise = _rotationClockwise;
        rotationSpeed = _rotationSpeed;
        rotationDirection = new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
    }

    private void Update() {
        if (rotationClockwise) {
            transform.RotateAround(parent.transform.position, parent.transform.up, orbitSpeed * Time.deltaTime); 
        }
        else {
            transform.RotateAround(parent.transform.position, -parent.transform.up, orbitSpeed * Time.deltaTime);
        }

        transform.Rotate(rotationDirection, rotationSpeed * Time.deltaTime);
    }
}
