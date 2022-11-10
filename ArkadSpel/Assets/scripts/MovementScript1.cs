using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript1 : MonoBehaviour
{
    public float speed = 2.0f; // holds variable of decimals
    public float speed2 = 20.0f; // i am speed
    public GameObject character;
    public Vector3 point; //position of the point you want to rotate around
    public float jumpHeight = 7f;
    public bool isGrounded;
    private Rigidbody rb;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Another object has entered the trigger");
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * speed * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.back * speed * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.up * jumpHeight);
        }
    }
}
