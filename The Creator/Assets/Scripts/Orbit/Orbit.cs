using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Orbit
{
    public float xAxis;
    public float yAxis;

    public Orbit(float xAxis, float yAxis)
    {
        this.xAxis = xAxis;
        this.yAxis = yAxis;
    }

    public Vector2 Evaluate(float t)
    {
        float angle = Mathf.Deg2Rad * 360 * t;
        float x = Mathf.Sin(angle) * xAxis;
        float y = Mathf.Cos(angle) * yAxis;
        return new Vector2(x, y);
    }

    public float FindOrbitProgress(float x, float y)
    {
        float angle = Mathf.Atan(y / x);
        angle = (float)3.14 - angle;
        angle = Mathf.Rad2Deg * angle;
        float t = angle / 360;
        //float t = angle / (Mathf.Deg2Rad * 360);
        return t;


        //double theta = Math.toDegrees(Math.atan2(y - cy, x - cx));
        /*float angle = Mathf.Rad2Deg * (Mathf.Atan2(y, x));
        float t = angle / 360;
        return t;*/
    }
}
