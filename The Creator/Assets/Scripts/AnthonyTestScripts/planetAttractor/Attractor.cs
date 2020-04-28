using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    [SerializeField] private float attraction = -10;

    public void Attract(Transform playerTransform) {
        Vector3 attractionUp = (playerTransform.position - transform.position).normalized;
        Vector3 localUp = playerTransform.transform.up;

        playerTransform.GetComponent<Rigidbody>().AddForce(attractionUp * attraction);

        Quaternion targetRotation = Quaternion.FromToRotation(localUp, attractionUp) * playerTransform.rotation;
        playerTransform.rotation = Quaternion.Slerp(playerTransform.rotation, targetRotation, 50f * Time.deltaTime);
    }
}
