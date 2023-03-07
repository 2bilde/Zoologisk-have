using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public float speed = 0.05f;
    public float jumpForce = 1.0f;
    private Rigidbody rb;
    public GameObject Player;

    void Update()
    {



        transform.position += Vector3.right * speed;

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.left * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.forward * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.back * speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }


    }
}
