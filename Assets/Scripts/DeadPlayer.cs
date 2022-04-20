using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public PhysicsScene Scene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
