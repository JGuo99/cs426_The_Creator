using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetEvolMenu : MonoBehaviour{

    [SerializeField] GameObject menuPane;
    [SerializeField] Button spawnButton;

    public AirCount resourceManager;
    private Text statusText;
    public static int stageStatus = 0;

    private void Start()
    {
        statusText = GetComponent<Text>();    
    }
    // Update is called once per frame
    void Update() {

        if (AirCount.airCount >= 15 && stageStatus < 3) {

            //enable button
            spawnButton.interactable = true;
        }
        if (stageStatus == 0)
        {
            statusText.text = "Dead Planet";
        }
        else if (stageStatus == 1)
        {
            statusText.text = "Dino Era";
        }
        else if (stageStatus == 2)
        {
            statusText.text = "Sapiens Era";
        }
        else
        {
            spawnButton.interactable = false;
        }
    }

    public void EvolvePlanet() {
        //evolve Planet via jeffs code

        //disable button again
        spawnButton.interactable = false;

        //decrement counter
        AirCount.airCount -= 15;

        //Set Stage Status
        stageStatus++;

        //close menu
        //menuPane.gameObject.SetActive(false);

    }
}