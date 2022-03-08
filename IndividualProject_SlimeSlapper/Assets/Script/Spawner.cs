using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    private void Start()
    {
        InvokeRepeating("spawn", 1, 1); //setting a spawning interval
    }

    void spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
