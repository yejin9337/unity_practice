using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _input;
    private Rigidbody _Rigidbody;
    
    public float Speed = 8f;

    void Start()
    {
        _input = GetComponent<PlayerInput>();
        _Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = _input.xInput * Speed;
        float zSpeed = _input.zInput * Speed;

        _Rigidbody.velocity = new Vector3(xSpeed, 0f, zSpeed);
    }
}
