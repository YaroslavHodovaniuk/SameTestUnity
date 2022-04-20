using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject plane;

    private void OnTriggerEnter(Collider other)
    {
        Invoke("DeActiveObject", 0.5f);
        Invoke("ActiveObject", 3);

    }
    void DeActiveObject()
    {
        //Объект выключается и включается.
        plane.SetActive(false);
    }
    void ActiveObject()
    {
        //Объект выключается и включается.
        plane.SetActive(true);
    }
}
