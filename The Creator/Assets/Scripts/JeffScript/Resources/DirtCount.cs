using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirtCount : MonoBehaviour
{
    public Text resourceText;
    public static int dirtCount = 0;

    private void Start()
    {
        dirtCount = 0;
        resourceText = GetComponent<Text>();
    }
    private void Update()
    {
        resourceText.text = "Dirt: " + dirtCount;
    }
}
