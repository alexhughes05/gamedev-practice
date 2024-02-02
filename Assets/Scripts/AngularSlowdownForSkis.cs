using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngularSlowdownForSkis : MonoBehaviour
{
    [SerializeField] private float dragMultiplier = 1f;
    [SerializeField] public Vector3 angleOfSight;
    [SerializeField] public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalAngle = Math.Abs(angleOfSight.x);
        angleOfSight = rb.transform.forward;
        Vector3 angleOfHill = new Vector3() { x=35, y=0 ,z=0 };

        rb.drag = horizontalAngle * dragMultiplier;
  
    }
}
