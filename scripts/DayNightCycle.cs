using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//@Author: Sarah Al Yahyaei
//@Date: 16 Dec 2020
public class DayNightCycle : MonoBehaviour
{
    public Transform sunLight; //Light object
    public int RotationScale;

    //Set speed of chnages
    void Start()
    {
        RotationScale = 4;
    }

    // Update day to night 
    void Update()
    {
        sunLight.Rotate(RotationScale * Time.deltaTime, 0, 0);
    }
}
