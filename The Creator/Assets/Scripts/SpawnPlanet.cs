using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlanet : MonoBehaviour
{
    public Rigidbody planetPrefab;
    public GameObject spawnPoint;
    public GameObject parentObject;
    Transform spawnTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            spawnTransform = spawnPoint.transform;
            Rigidbody planetInstance;
            planetInstance = Instantiate(planetPrefab, spawnTransform.position, spawnTransform.rotation, parentObject.transform);
            //planetInstance = Instantiate(planetPrefab, spawnTransform);
        }
    }
}
