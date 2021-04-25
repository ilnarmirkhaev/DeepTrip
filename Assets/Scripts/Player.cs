using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;

    public int speed = 10;
    public Boolean reversed;

    private Rigidbody2D _rb;
    private Vector2 _moveVelocity;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput;
        if (reversed)
            moveInput = new Vector2(-Input.GetAxisRaw("Horizontal"), -Input.GetAxisRaw("Vertical"));
        else
            moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        _moveVelocity = moveInput.normalized * speed;
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _moveVelocity * Time.fixedDeltaTime);
    }
}
