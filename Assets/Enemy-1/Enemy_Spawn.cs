using UnityEngine;
using System.Collections;
public class Enemy_Spawn : MonoBehaviour
{
public float minSpawnDelay = 1f;
public float maxSpawnDelay = 3f;
public GameObject meteorPrefab;
void Start () 
{
Spawn ();
}
void Spawn ()
 {

Vector3 spawnPos = transform.position + new Vector3(Random.Range(-6, 6), 0, -1);
Instantiate (meteorPrefab, spawnPos, Quaternion.identity);
Invoke ("Spawn", Random.Range (minSpawnDelay, maxSpawnDelay));
}
}