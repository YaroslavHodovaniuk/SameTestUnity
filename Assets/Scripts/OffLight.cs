using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLight : MonoBehaviour
{
    // Start is called before the first frame update
    public Light light;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            light.enabled = true;
        }
    }
}
