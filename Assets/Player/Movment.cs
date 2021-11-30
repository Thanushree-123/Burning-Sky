using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{ 
    
    public float moveSpeed = 5f;
    
    void Start ()
    {
      
    }
   
    // Update is called once per frame
    void Update ()
    {
        transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical")* moveSpeed);
      //Moves Left and right along x Axis                               //Left/Right
    transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal")* moveSpeed);      
    }

    
}
