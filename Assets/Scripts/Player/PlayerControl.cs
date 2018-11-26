using UnityEngine;

public class PlayerControl : MonoBehaviour {
    private int score;

    // jump control
    public Rigidbody2D rb;
    public float JumpForce = 5.0f;

    public float MaxSpeed = 5.0f;

    // Player Movement
    void Update()
    {   
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        //float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.position = new Vector3(transform.position.x + horizontal * MaxSpeed, transform.position.y);
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0.0f, JumpForce), ForceMode2D.Impulse);
        }
    }

    // Screen Binding - Left-hand side
    private void LateUpdate()
    {
        float currentX = transform.position.x;

        if ( currentX < -8.3f)
        {
            transform.position = new Vector3(-8.3f, transform.position.y);
        }
    }
}

 
