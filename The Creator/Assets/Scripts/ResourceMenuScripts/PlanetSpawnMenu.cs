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

    public AudioClip constructionSound;
    public AudioSource audioSource;

    private void Start()
    {
        //audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
        if (DirtCount.dirtCount >= 25 && CoreCount.coreCount >= 1) { //Changed for testing

            //enable button
            spawnButton.interactable = true;
        }
    }

    public void SpawnPlanet() {
        //Sound Effect
        audioSource.PlayOneShot(constructionSound, .5f);

        //spawn planet via seans code
        spawnTransform = spawnPoint.transform;
        Rigidbody planetInstance;
        planetInstance = Instantiate(planetPrefab, spawnTransform.position, spawnTransform.rotation, parentObject.transform);
        //planetInstance = Instantiate(planetPrefab, spawnTransform);

        //disable button again
        spawnButton.interactable = false;

        //decrement counter
        DirtCount.dirtCount -= 25;
        CoreCount.coreCount -= 1;

        //close menu
        menuPane.gameObject.SetActive(false);
    }
}
