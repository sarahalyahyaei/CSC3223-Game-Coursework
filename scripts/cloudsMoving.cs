using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//@Date: Dec 2020
//Code extnded from https://low-scope.com/unity-quick-the-most-common-ways-to-move-a-object/
public class cloudsMoving : MonoBehaviour
{
    [SerializeField] private Vector3 pointA = new Vector3(-70.9f, -23.9f, 0);
    [SerializeField] private Vector3 pointB = new Vector3(70.9f, -23.9f, 0);
    [SerializeField] private float speed = 0.0002f;
    private float t;

    private void Update()
    {
        t += Time.deltaTime * speed;

        transform.position = Vector3.Lerp(pointA, pointB, t);

        if (t >= 1)
        {
            var a = pointB;
            var aa = pointA;

            t = 0;

        }
    }


    private Vector3 CustomLerp(Vector3 a, Vector3 b, float t)
    {
        return a * (1 - t) + b * t;
    }
}