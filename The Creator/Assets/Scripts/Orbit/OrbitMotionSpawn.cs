using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OrbitMotionSpawn : MonoBehaviour
{
    public Transform orbitingObject;
    Orbit orbitPath;

    public GameObject parentObject;
    public GameObject revolvingObject;
    Vector3 parentPos;
    public GameObject spawnPosObject;

    [Range(0f, 1f)]
    //public float orbitProgress = 0f;
    float orbitProgress;
    float orbitPeriod = 10f;
    public bool orbitActive = true;

    // Start is called before the first frame update
    void Start()
    {
        //spawnPos = spawnTrans.position;
        Vector3 spawnPos = this.transform.position;

        parentPos = parentObject.transform.position;
        //Vector3 spawnPos = spawnPosObject.transform.position;

        //Debug.Log(parentPos);
        //Debug.Log(spawnPos);

        float xDistance = Mathf.Abs(parentPos.x - spawnPos.x);
        float zDistance = Mathf.Abs(parentPos.z - spawnPos.z);
        float totalDist = Mathf.Sqrt(Mathf.Pow(xDistance, 2) + Mathf.Pow(zDistance, 2));

        //Debug.Log(xDistance);
        //Debug.Log(zDistance);
        //Debug.Log(totalDist);

        float maxValue = Mathf.Max(xDistance, zDistance);
        //Debug.Log(maxValue);

        orbitPath = new Orbit(totalDist, totalDist);
        orbitProgress = orbitPath.FindOrbitProgress(spawnPos.x, spawnPos.z);
        Debug.Log(orbitProgress);

        if (orbitingObject == null)
        {
            orbitActive = false;
            return;
        }
        SetOrbitingObjectPosition();
        StartCoroutine(AnimateOrbit());
    }

    void SetOrbitingObjectPosition()
    {
        Vector2 orbitPos = orbitPath.Evaluate(orbitProgress);
        orbitingObject.localPosition = new Vector3(orbitPos.x, 0, orbitPos.y);
    }

    IEnumerator AnimateOrbit()
    {
        if (orbitPeriod < 0.1f)
        {
            orbitPeriod = 0.1f;
        }

        float orbitSpeed = 1f / orbitPeriod;
        while (orbitActive)
        {
            orbitProgress += Time.deltaTime * orbitSpeed;
            orbitProgress %= 1f;
            SetOrbitingObjectPosition();
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
