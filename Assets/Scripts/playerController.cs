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

    public bool isGrounded;
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
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
            isGrounded = false;
        }


    }

    void OnCollisionEnter()
    {
        isGrounded = true;
    }

    void MoveGameObject()
    {
        Player.transform.position = new Vector3(5, -6, 25);
    }

    void OnCollisionEnter(Collision collision)
    {

        MoveGameObject();

    }

}
