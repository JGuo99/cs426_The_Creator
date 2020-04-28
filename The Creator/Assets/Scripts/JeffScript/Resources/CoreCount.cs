using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoreCount : MonoBehaviour
{
    public Text resourceText;
    public static int coreCount;

    private void Start()
    {
        coreCount = 0;
        resourceText = GetComponent<Text>();
    }
    private void Update()
    {
        resourceText.text = "Core: " + coreCount;
    }
}
