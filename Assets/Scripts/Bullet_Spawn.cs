using UnityEngine;
using System.Collections;
public class Bullet_Spawn : MonoBehaviour
{
public float minSpawnDelay = 1f;
public float maxSpawnDelay = 3f;
public GameObject bulletPrefab;
void Start () 
{
Spawn ();
}
void Spawn ()
 {

Vector3 spawnPos = transform.position + new Vector3(0, -4, -1);
Instantiate (bulletPrefab, spawnPos, Quaternion.identity);
Invoke ("Spawn", Random.Range (minSpawnDelay, maxSpawnDelay));
}
}
