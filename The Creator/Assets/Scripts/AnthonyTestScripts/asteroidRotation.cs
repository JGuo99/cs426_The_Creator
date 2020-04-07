using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidRotation : MonoBehaviour
{
    private Vector3 target = new Vector3(60.0f, 0.0f, 0.0f);

    void Update() {
        // Spin the object around the world origin at 20 degrees/second.
        transform.RotateAround(target, Vector3.up, 15 * Time.deltaTime);
    }
}
