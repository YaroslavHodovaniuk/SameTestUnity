using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffLight : MonoBehaviour
{
    // Start is called before the first frame update
    public Light light;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            light.enabled = false;
        }
    }
}