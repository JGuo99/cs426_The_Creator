using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetEvolMenu : MonoBehaviour{

    [SerializeField] GameObject menuPane;
    [SerializeField] Button spawnButton;

    public AirCount resourceManager;


    // Update is called once per frame
    void Update() {

        if (AirCount.airCount >= 15) {

            //enable button
            spawnButton.interactable = true;
        }
    }

    public void EvolvePlanet() {
        //evolve Planet via jeffs code

        //disable button again
        spawnButton.interactable = false;

        //decrement counter
        AirCount.airCount -= 15;

        //close menu
        menuPane.gameObject.SetActive(false);

    }
}
