using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IronCount : MonoBehaviour
{
    public Text resourceText;
    public static int ironCount;

    private void Start()
    {
        ironCount = 0;
        resourceText = GetComponent<Text>();
    }
    private void Update()
    {
        resourceText.text = "Iron: " + ironCount;
    }
}
