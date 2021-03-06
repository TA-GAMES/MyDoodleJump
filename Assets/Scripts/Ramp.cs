﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component will make any object that will hit object with this component
 * to bounce with specif force
 */
public class Ramp : MonoBehaviour { 

    public float jumpForce = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }

        
        }
    }


}
