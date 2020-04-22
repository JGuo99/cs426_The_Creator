using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterCount : MonoBehaviour
{
    public Text resourceText;
    public static int waterCount = 0;

    private void Start()
    {
        waterCount = 0;
        resourceText = GetComponent<Text>();
    }
    private void Update()
    {
        resourceText.text = "Water: " + waterCount;
    }
}
