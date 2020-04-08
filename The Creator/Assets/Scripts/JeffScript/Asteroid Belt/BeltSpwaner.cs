using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltSpwaner : MonoBehaviour
{
    [Header("Spawner Settings")] //Spawning of the Belt
    public GameObject asteroidPrefab;
    public int asteroidAmount; //How many asteroid will be rotating inside the belt
    public int seed; //Random sequence
    //Range of Belt
    public float innerRadiusFromStar;
    public float outerRadiusFromStar;
    public float height;
    public bool clockwiseRotation;

    [Header("Asteroid Settings")]
    public float minOrbitSpeed;
    public float maxOrbitSpeed;
    public float minRotationSpeed;
    public float maxRotationSpeed;

    //Use to place object in the right location realitive to the Star (NOT origin)
    private Vector3 localPosition;
    private Vector3 worldOffset;
    private Vector3 worldPosition;
    private float randomRadius;
    private float randomRadian; //0 - 2pi
    private float x, y, z;

    //Simple Calculus
    //x = xOrigin (0) + r * cos(a)
    //y = yOigin (0) + r * sin(a)

    private void Start()
    {
        Random.InitState(seed);
        for(int i = 0; i < asteroidAmount; i++)
        {
            do {
                //Generate a random radius/radian from set range
                randomRadius = Random.Range(innerRadiusFromStar, outerRadiusFromStar);
                randomRadian = Random.Range(0, (2 * Mathf.PI));

                //Coordinate for belt placement
                y = Random.Range(-(height / 2), (height / 2));
                x = randomRadius * Mathf.Cos(randomRadian);
                z = randomRadius * Mathf.Sin(randomRadian);


            } while (float.IsNaN(z) && float.IsNaN(x)); //Allows unity to search until vaild x and z

            localPosition = new Vector3(x, y, z); //Helps translate from locoal position to world position
            worldOffset = transform.rotation * localPosition; //Rotate object correctly base on position
            worldPosition = transform.position + worldOffset; //Get distance and add to position

            //This will randomly place new generated asteroids with randomly generated rotation 
            GameObject newAsteroid = Instantiate(asteroidPrefab, worldPosition, Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
            newAsteroid.AddComponent<AsteroidBelt>().SetupAsteroidBelt(Random.Range(minOrbitSpeed, maxOrbitSpeed), Random.Range(minRotationSpeed, maxRotationSpeed), gameObject, clockwiseRotation);
            newAsteroid.transform.SetParent(transform); //This will set the parent (belt) of whatever the new asteroid spwan on
            
        }
    }

}
