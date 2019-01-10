using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    // Enemy Patrol 

    public float moveSpeed = 5f;
    Transform LeftWaypoint, RightWaypoint;
    Vector3 LocalScale;
    bool MovingRight = true;
    Rigidbody2D rb;

    void Start()
    {
        LocalScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        LeftWaypoint = GameObject.Find ("LeftWaypoint").GetComponent<Transform>();
        RightWaypoint = GameObject.Find("RightWaypoint").GetComponent<Transform>();
    }

    void Update()
    {
        if (transform.position.x > RightWaypoint.position.x)
            MovingRight = false;

        if (transform.position.x < LeftWaypoint.position.x)
            MovingRight = true;

        if (MovingRight)
            MoveRight();
        else
            MoveLeft();
    }

    void MoveRight()
    {
        MovingRight = true;
        LocalScale.x = 1;
        transform.localScale = LocalScale;
        rb.velocity = new Vector2 (LocalScale.x * moveSpeed, rb.velocity.y);

    }

    void MoveLeft()
    {
        MovingRight = false;
        LocalScale.x = -1;
        transform.localScale = LocalScale;
        rb.velocity = new Vector2(LocalScale.x * moveSpeed, rb.velocity.y);

    }


    // If the enemy collides with the player then player losses health
    void OnCollisionEnter2D(Collision2D hit)
    {
     if (hit.gameObject.tag.Equals("Player"))
        {
            HealthBar.Health -= 10f;
        }  
    }

    // Enemy damage

    public int Health = 100;
    public void TakeDamage (int damage)
    {
        Health -= damage;

        if (Health <-0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

}
