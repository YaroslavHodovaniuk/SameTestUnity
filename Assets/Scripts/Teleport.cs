using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform portal;
    private void OnTriggerStay(Collider other)
    {
        Transform playerTr;
        if (other.CompareTag("Player"))
        {
            playerTr = other.GetComponent<Transform>();
            playerTr.position = portal.position;
        }
    }
}
