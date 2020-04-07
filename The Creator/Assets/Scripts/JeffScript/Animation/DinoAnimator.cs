using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoAnimator : MonoBehaviour
{
    private Animator animate;
    private const string idle_bool = "idle";
    private const string attack_bool = "attack";
    // Start is called before the first frame update
    void Start()
    {
        animate = GetComponent<Animator>();
        foreach(AnimatorControllerParameter parameter in animate.parameters) {
            animate.SetBool(parameter.name, true);
        }
        
    }
}
