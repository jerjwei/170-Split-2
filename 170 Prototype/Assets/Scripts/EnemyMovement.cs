﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Rigidbody2D rb;

    public int enemySpeed = 3;
    public int horizontalDirection;
    //public float bounceDistance = 0.7f;

    // Update is called once per frame
    void Update()
    {
        /*RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(horizontalDirection, 0));*/
        rb.velocity = new Vector2(horizontalDirection * enemySpeed, rb.velocity.y);

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // if collide with Air Wall
        if(col.tag == "Air_Wall"){
            Flip();
        }

    }

    //turn the horizontal direction to the other way
    void Flip()
    {
        if(horizontalDirection > 0)
        {
            horizontalDirection = -1;
        }
        else
        {
            horizontalDirection = 1;
        }


    }
}
