using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript1 : MonoBehaviour
{
    public float speed = 2.0f; // holds variable of decimals
    public float speed2 = 20.0f; // i am speed
    public GameObject character;
    public Vector3 point; //position of the point you want to rotate around
    float jumpHeight = 5.0f;
    bool isGrounded;
    public Rigidbody rb;

    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float ZVelocity = rb.velocity.z;
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeForce(Vector3.forward * speed * speed);
            Debug.Log(rb.velocity.z);
            if (ZVelocity < 2)
            {
                ZVelocity = 2;
            }
            if (ZVelocity > 7)
            {
                ZVelocity = 7;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeForce(Vector3.back * speed * speed);
            if (ZVelocity > -2)
            {
                ZVelocity = -2;
            }
            if (ZVelocity < -7)
            {
                ZVelocity = -7;
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (isGrounded == true)
            {
                rb.velocity = Vector3.up * jumpHeight;
                isGrounded = false;
            }
        }
    }
    void FixedUpdate()
    {
        if (!isGrounded && jumpHeight > 0)
        {
            rb.AddForce(0, jumpHeight, 0);
        }

    }

    void OnCollisionEnter(Collision col)
    {
        isGrounded = true;
    }
}