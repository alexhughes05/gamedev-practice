using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float RotateSpeed = 30f;
    [SerializeField] private float TurningForce = 5f;
    [SerializeField] private Vector3 currentVelocity;
    [SerializeField] public Rigidbody Rigidbody;

    private void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        var direction = Input.GetAxisRaw("Horizontal");
        currentVelocity = Rigidbody.velocity;

        // Rotate character based on the RotateSpeed variable
        var rotation = Vector3.up * direction * RotateSpeed * Time.deltaTime;
        RotateCharater(rotation);

    }
    void RotateCharater(Vector3 rotation) => transform.Rotate(rotation);

    void FixedUpdate()
    {
        // Get the current velocity
        Vector3 currentVelocity = Rigidbody.velocity;
        var direction = Input.GetAxisRaw("Horizontal");
        currentVelocity = Rigidbody.velocity;

        // Calculate the force based on the rotation
        Vector3 rotationForce = transform.right * direction * TurningForce;

        // Add the force to the Rigidbody
        Rigidbody.AddForce(rotationForce);

        // Limit the maximum velocity if needed
        float maxVelocity = 10f;
        Rigidbody.velocity = Vector3.ClampMagnitude(currentVelocity, maxVelocity);
    }

}
