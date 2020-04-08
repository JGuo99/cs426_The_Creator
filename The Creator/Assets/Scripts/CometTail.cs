using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometTail : MonoBehaviour
{
    public GameObject comet;
    public GameObject star;

    public float threshhold;
    bool closeToStar;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<ParticleSystem>().Stop();

        closeToStar = false;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(comet.transform.position, star.transform.position);
        //Debug.Log(distance);

        if (!closeToStar && distance < threshhold)
        {
            //Debug.Log("Close");
            closeToStar = true;
            this.GetComponent<ParticleSystem>().Play();
        }
        if (closeToStar && distance > threshhold)
        {
            //Debug.Log("Far");
            closeToStar = false;
            this.GetComponent<ParticleSystem>().Stop();
        }

        /*//For Testing
        if (Input.GetKey(KeyCode.RightShift))
        {
            this.GetComponent<ParticleSystem>().Stop();
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            this.GetComponent<ParticleSystem>().Play();
        }*/
    }
}
