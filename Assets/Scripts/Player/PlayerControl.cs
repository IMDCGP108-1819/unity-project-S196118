﻿using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private int score;

    // Player Movement
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        //float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.position = new Vector3(transform.position.x + horizontal * MaxSpeed, transform.position.y);
    }

    // Jump function
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0.0f, JumpForce), ForceMode2D.Impulse);
        }
    }
    // Jump control
    public Rigidbody2D rb;
    public float JumpForce = 5.0f;
    public float MaxSpeed = 8.0f;

    // flip Character - depending on direction

    private bool facingright = true;
        
        if(facingright == false && moveinput > 0)
        {
         flip();
        } else if(facingright == true && moveinput < 0){
            flip();
}
        void flip()
    {
        facingright = !facingright;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
        
    // Jump limit 
    
   if (currenty< 8.0f)
    
        {
            transform.position = new Vector3(transform.position.x, 8.0f);
        }

    // Screen Binding - Left
    private void LateUpdate()
    {
        float currentx = transform.position.x;

        if (currentx < -8.3f)
        {
            transform.position = new Vector3(-8.3f, transform.position.x);
        }

        // Shooting function - upon item pick up
        {

        }
    }

}