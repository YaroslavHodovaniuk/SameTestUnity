using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSphere : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody player;
    public float force;
    public float jumpForce;
    private AudioSource AudioSourceForPlayer;
    void Start()
    {
        AudioSourceForPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            player.AddForce(Vector3.forward * force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.AddForce(Vector3.left * force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.AddForce(Vector3.back * force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.AddForce(Vector3.right * force);
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (player.velocity != Vector3.zero)
        {
            AudioSourceForPlayer.Play();
        }
        else
        {
            AudioSourceForPlayer.Stop();
        }
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            player.AddForce(Vector3.up * jumpForce);
        }

    }
}
