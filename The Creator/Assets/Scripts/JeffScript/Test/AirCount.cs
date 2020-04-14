using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirCount : MonoBehaviour
{
    public Text resourceText;
    public static int airCount = 0;

    private void Start()
    {
        airCount = 0;
        resourceText = GetComponent<Text>();
    }
    private void Update()
    {
        resourceText.text = "Air: " + airCount;
    }
}
