using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    public float despawnTimer;
    private void Update()
    {
        Destroy(gameObject, despawnTimer);
    }
}
