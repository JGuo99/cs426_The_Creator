using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public void GameScene() {
        SceneManager.LoadScene("MainScene");
    }

    public void IntroScene() {
        SceneManager.LoadScene("IntroScene");
    }

    public void CreditScene() {
        SceneManager.LoadScene("CreditScene");
    }

    public void ExitGame() {
        Application.Quit();
    }
}
