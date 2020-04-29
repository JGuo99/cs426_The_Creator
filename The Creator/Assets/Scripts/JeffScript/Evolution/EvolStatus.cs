using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvolStatus : MonoBehaviour
{
    public static int nextStage = 0;
    public Text statusText;
    // Start is called before the first frame update
    void Start()
    {
        statusText.text = "Dead Planet";
    }

    // Update is called once per frame
    void Update()
    {
        if (nextStage == 0)
        {
            statusText.text = "Dead Planet";
        }
        else if (nextStage == 1)
        {
            statusText.text = "Water Era";
        }
        else if (nextStage == 2)
        {
            statusText.text = "Dino Era";
        }
        else if (nextStage == 3)
        {
            statusText.text = "Sapiens Era";
        }


    }
}
