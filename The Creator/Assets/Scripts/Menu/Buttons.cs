using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour{

    [SerializeField] GameObject planet2;
    [SerializeField] GameObject planet3;
    [SerializeField] GameObject planet4;
    [SerializeField] GameObject planet5;
    [SerializeField] GameObject planet6;

    public void SpawnPlanet2() {
        planet2.gameObject.SetActive(true);
        //Code to spawn planet one here
    }

    public void SpawnPlanet3() {
        planet3.gameObject.SetActive(true);
        //Code to spawn planet one here
    }

    public void SpawnPlanet4() {
        planet4.gameObject.SetActive(true);
        //Code to spawn planet one here
    }

    public void SpawnPlanet5() {
        planet5.gameObject.SetActive(true);
        //Code to spawn planet one here
    }

    public void SpawnPlanet6() {
        planet6.gameObject.SetActive(true);
        //Code to spawn planet one here
    }

    public void ExitGame() {
        Application.Quit();
    }
}
