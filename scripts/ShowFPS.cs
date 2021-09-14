using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Code implemented from https://answers.unity.com/questions/1189486/how-to-see-fps-frames-per-second.html
//@Date 4 Dec 2020
//@Aim: To display framerate per second during the game.
public class ShowFPS : MonoBehaviour
{
    public Text fpsText;
    private float deltaTime;

    // Update is called once per frame
    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        fpsText.text = Mathf.Ceil (fps).ToString() + "fps";
    }
}
