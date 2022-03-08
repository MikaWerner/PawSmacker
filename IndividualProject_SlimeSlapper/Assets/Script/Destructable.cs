using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
{
    //References
    public GameObject DestroyedVersion;
    public float expForce, radius;

    void OnTriggerEnter(Collider other)
    {
        Instantiate(DestroyedVersion, transform.position, transform.rotation); //spawn destroyed version 
        knockBack();
        Destroy(gameObject); //destroy current object
    }

    void knockBack()    //explosive type of force
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider nearby in colliders)
        {
            Rigidbody rb = nearby.GetComponent<Rigidbody>();
            if (rb != null)
                rb.AddExplosionForce(expForce, transform.position, radius);
        }

    }
}
