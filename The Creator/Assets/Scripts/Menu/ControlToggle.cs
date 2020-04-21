using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlToggle : MonoBehaviour
{
    [SerializeField] GameObject menuPane;
    bool toggleFlag = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            toggleFlag = !toggleFlag;

            Cursor.visible = toggleFlag;
            menuPane.gameObject.SetActive(toggleFlag);
        }

    }
    public void ExitGame() {
        Application.Quit();
    }
}
