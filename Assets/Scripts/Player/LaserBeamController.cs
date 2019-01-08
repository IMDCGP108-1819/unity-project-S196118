using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeamController : MonoBehaviour
{

    public float speed = 40f;
    public Rigidbody2D rb;

    // Laser Velocity
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
}
