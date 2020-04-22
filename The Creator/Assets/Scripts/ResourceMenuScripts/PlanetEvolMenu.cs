using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetEvolMenu : MonoBehaviour{

    [SerializeField] GameObject menuPane;
    [SerializeField] Button spawnButton;

    /*public EvolutionMaterial emManager; 
    public WaterCount waterManager;
    public IronCount ironManager;
    public DirtCount dirtManager;*/
    //public Text statusText;
    public static int stageStatus = 0;

    private void Start()
    {
        //statusText = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update() {

        if (WaterCount.waterCount >= 15 && IronCount.ironCount >= 15 && DirtCount.dirtCount >= 15 && stageStatus < 3) {

            //enable button
            spawnButton.interactable = true;
        }
        //if (stageStatus == 1)
        //{
        //    EvolStatus.nextStage += 1;
        //}
        //else if (stageStatus == 2)
        //{
        //    EvolStatus.nextStage += 1;
        //}
        //else
        //{
        //    spawnButton.interactable = false;
        //}
    }

    public void EvolvePlanet() {
        //evolve Planet via jeffs code

        //disable button again
        spawnButton.interactable = false;

        //decrement counter
        WaterCount.waterCount -= 15;
        IronCount.ironCount -= 15;
        DirtCount.dirtCount -= 15;
        //Set Stage Status
        stageStatus++;
        EvolutionMaterial.nextMaterial += 1;
        //close menu
        //menuPane.gameObject.SetActive(false);

    }
}