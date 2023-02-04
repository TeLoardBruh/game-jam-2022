using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody rb;
    public float movementSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {   
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
    }


    void FixedUpdate() {
        // if(Input.GetKey("w")) {
        //     rb.velocity = new Vector3(0,0,5);
        // }
        // if(Input.GetKey("s")) {
        //     rb.velocity = new Vector3(0,0,-5);
        // }
        // if(Input.GetKey("a")) {
        //     rb.velocity = new Vector3(-5,0,0);
        // }
        // if(Input.GetKey("d")) {
        //     rb.velocity = new Vector3(5,0,0);
        // }    
    }
}
