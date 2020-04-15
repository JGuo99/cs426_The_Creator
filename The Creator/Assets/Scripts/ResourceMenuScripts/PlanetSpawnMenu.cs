using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetSpawnMenu : MonoBehaviour {

    [SerializeField] GameObject menuPane;
    [SerializeField] Button spawnButton;

    public DirtCount resourceManager;

    //From Seans code
    public Rigidbody planetPrefab;
    public GameObject spawnPoint;
    public GameObject parentObject;
    Transform spawnTransform;


    // Update is called once per frame
    void Update() {

        if (DirtCount.dirtCount >= 25) {

            //enable button
            spawnButton.interactable = true;
        }
    }

    public void SpawnPlanet() {
        //spawn planet via seans code
        spawnTransform = spawnPoint.transform;
        Rigidbody planetInstance;
        planetInstance = Instantiate(planetPrefab, spawnTransform.position, spawnTransform.rotation, parentObject.transform);
        //planetInstance = Instantiate(planetPrefab, spawnTransform);

        //disable button again
        spawnButton.interactable = false;

        //decrement counter
        DirtCount.dirtCount -= 25;

        //close menu
        menuPane.gameObject.SetActive(false);
    }
}
