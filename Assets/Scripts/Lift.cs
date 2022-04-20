using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    public float force;

    private void OnTriggerStay(Collider other)
    {
        Rigidbody playerRb;
        playerRb = other.GetComponent<Rigidbody>();
        playerRb.AddForce(transform.up * force);
    }
}
