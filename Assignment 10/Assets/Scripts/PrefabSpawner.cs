using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;

    void FixedUpdate()
    {
        Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
    }
}
