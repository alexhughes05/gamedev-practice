using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTest : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private Rigidbody _rgbd;

    // Start is called before the first frame update
    void Start()
    {
        _rgbd.AddForce(Vector3.down * _force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
