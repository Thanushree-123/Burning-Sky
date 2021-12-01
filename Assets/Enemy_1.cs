using UnityEngine;
using System.Collections;
public class Enemy_1 : MonoBehaviour
{
public float speed = -2f;
private Rigidbody2D rigidBody;
// Use this for initialization
void Start ()
{
rigidBody = GetComponent<Rigidbody2D> ();
rigidBody.velocity = new Vector2 (0, speed);
}

}