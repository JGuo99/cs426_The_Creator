using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour{

    [SerializeField] GameObject planet2;

    public void SpawnPlanet2() {
        planet2.gameObject.SetActive(true);
        //Code to spawn planet one here
    }

    public void SpawnPlanet3() {
        //Code to spawn planet one here
    }

    public void SpawnPlanet4() {
        //Code to spawn planet one here
    }

    public void SpawnPlanet5() {
        //Code to spawn planet one here
    }

    public void ExitGame() {
        Application.Quit();
    }
}
