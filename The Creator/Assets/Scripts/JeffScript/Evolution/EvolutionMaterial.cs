using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvolutionMaterial : MonoBehaviour
{
    public Material[] materials; //Dynamically add planet texture amount
    public static int nextMaterial;
    Renderer rend;

    [SerializeField] GameObject[] staticModels;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[0];
        staticModels[0].active = true;
    }

    // Update is called once per frame
    void Update()
    {
        //nextMaterial++;
        nextMaterial %= materials.Length; //Prevent it from going out of bound.
        rend.sharedMaterial = materials[nextMaterial];
        if (nextMaterial == 1)
        {
            staticModels[0].active = false;
            staticModels[1].active = true;
            staticModels[2].active = false;
            staticModels[3].active = false;
        }
        else if(nextMaterial == 2)
        {
            staticModels[0].active = false;
            staticModels[1].active = false;
            staticModels[2].active = true;
            staticModels[3].active = false;
        }
        else if (nextMaterial == 3)
        {
            staticModels[0].active = false;
            staticModels[1].active = false;
            staticModels[2].active = false;
            staticModels[3].active = true;
        }
    }
}
