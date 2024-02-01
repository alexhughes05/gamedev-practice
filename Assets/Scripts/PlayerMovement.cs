using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float RotateSpeed = 60f;
    [SerializeField] private float TurningForce = 10f;
    [SerializeField] private Vector3 currentVelocity;
    [SerializeField] public Rigidbody Rigidbody;

    private void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        bool slowRotate = !Input.GetKey(KeyCode.DownArrow);
        float FastRotateSpeed = RotateSpeed * 2;
        var direction = Input.GetAxisRaw("Horizontal");
        currentVelocity = Rigidbody.velocity;

        // Rotate character based on the RotateSpeed variable
        var rotation = Vector3.up * direction * (slowRotate ? RotateSpeed : FastRotateSpeed) * Time.deltaTime;
        RotateCharater(rotation);

    }
    void RotateCharater(Vector3 rotation) => transform.Rotate(rotation);

    void FixedUpdate()
    {
        bool slowRotate = !Input.GetKey(KeyCode.DownArrow);
        float FastTurningForce = TurningForce * 2;

        // Get the current velocity
        var direction = Input.GetAxisRaw("Horizontal");
        currentVelocity = Rigidbody.velocity;

        // Calculate the force based on the rotation
        Vector3 rotationForce = transform.right * direction * (slowRotate ? TurningForce : FastTurningForce);

        // Add the force to the Rigidbody
        Rigidbody.AddForce(rotationForce);

    }

}
