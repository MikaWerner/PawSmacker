using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBox : MonoBehaviour
{
    public Rigidbody rb;
    public float movementSpeed = -200f;
    public float despawnTimer;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, movementSpeed);
        Destroy(gameObject, despawnTimer);
    }
}




