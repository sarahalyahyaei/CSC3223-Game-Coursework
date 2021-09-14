using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code https://www.youtube.com/watch?v=_QajrabyTJc
//Extnded by Sarah Al Yahyaei
//@Date: Dec 2020
public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            float x = Input.GetAxis("Horizontal"); //moving left to right, and right to left
            float z = Input.GetAxis("Vertical"); // moving forward and backwards

            Vector3 move = transform.right * x + transform.forward * z; //Directions

            controller.Move(move * speed * Time.deltaTime);
        }

    }
}
