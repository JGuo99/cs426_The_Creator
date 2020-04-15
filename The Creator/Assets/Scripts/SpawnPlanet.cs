using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlanet : MonoBehaviour
{
    [SerializeField] GameObject menuPane;

    private bool active = false;

    //public Rigidbody planetPrefab;
    //public GameObject spawnPoint;
    //public GameObject parentObject;
    //Transform spawnTransform;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            if (active) {
                menuPane.gameObject.SetActive(false);
                
            } else {
                menuPane.gameObject.SetActive(true);
            }
            active = !active;

            //spawnTransform = spawnPoint.transform;
            //Rigidbody planetInstance;
            //planetInstance = Instantiate(planetPrefab, spawnTransform.position, spawnTransform.rotation, parentObject.transform);
            //planetInstance = Instantiate(planetPrefab, spawnTransform);
        }
    }
}
