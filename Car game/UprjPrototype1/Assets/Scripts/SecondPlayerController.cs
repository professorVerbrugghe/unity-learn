using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float rotationSpeed = 50f;
    private float horizontalInput;
    private float verticalInput;

    public float mass;
    public Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        //horizontal and vertical input with input system
        horizontalInput = Input.GetAxis("Horizontal2");
        verticalInput = Input.GetAxis("Vertical2");

        //move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //rotate vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * horizontalInput);
    }
}
