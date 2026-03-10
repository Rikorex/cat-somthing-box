using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class playermovementbasic : MonoBehaviour
{
    private float movespeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveinput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveinput * movespeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveinput = context.ReadValue<Vector2>();
    }
}

