using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

//@Author: Sarah Al Yahyaei
//@Date: 14 Dec 2020
public class TotalMemory : MonoBehaviour
{
    public Text fpsText;
    // Update is called once per frame
    void Update()
    {
        float memorySize = GC.GetTotalMemory(true);
        fpsText.text= Mathf.Ceil(memorySize).ToString() + "memory";
    }
}
