using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float RotateSpeed = 30f;

    CharacterController characterController;
    // Update is called once per frame
    void Update()
    {
        var direction = Input.GetAxisRaw("Horizontal");
        transform.Rotate(Vector3.up * direction * RotateSpeed * Time.deltaTime);
    }
}
