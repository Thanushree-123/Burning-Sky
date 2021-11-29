using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling_Bg : MonoBehaviour
{
    public float speed = -2f;

void Update ()
 {
   transform.Translate(0f, speed * Time.deltaTime, 0f);
   if(transform.position.y <= -20)
   {
     transform.Translate(0f, 40f, 0f);
   }
 }
}
