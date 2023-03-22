using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 10f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Move forward or backward based on user input
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * moveVertical * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);

        // Move left or right based on user input
        float moveHorizontal = Input.GetAxis("Horizontal");
        movement = transform.right * moveHorizontal * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);

        // Turn left or right based on user input
        float turn = Input.GetAxis("Mouse X");
        Quaternion turnRotation = Quaternion.Euler(0f, turn * turnSpeed * Time.deltaTime, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}

