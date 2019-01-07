using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private int score;
    private bool isFacingRight = true;
    private float MovementDirection;

    // Player Movement

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        transform.position = new Vector3(transform.position.x + horizontal * MaxSpeed, transform.position.y);

        // Movement Direction

        MovementDirection = Input.GetAxisRaw("Horizontal");
        
        // Flip

        if(isFacingRight && MovementDirection > 0)
        {
            Flip();
        }else if (!isFacingRight && MovementDirection < 0)
        {
            Flip();
        }

    }

    // Flip function
    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0.0f, 180f, 0f);
    }
   
    // Jump control
    public Rigidbody2D rb;
    public float JumpForce = 5.0f;
    public float MaxSpeed = 8.0f;

    // Jump function
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0.0f, JumpForce), ForceMode2D.Impulse);
        }
    }
  
    // Screen Binding - Left and Right
    private void LateUpdate()
    {
        float currentx = transform.position.x;
        float currenty = transform.position.y;
        
        // Left
        if (currentx < -8.3f)
        {
            transform.position = new Vector3(-8.3f, currenty);
        }

        //Right
        if (currentx > 464.0f)
        {
            transform.position = new Vector3(464.0f, currenty);
        }

        //Top
        if (currenty > 57.0f)
        {
            transform.position = new Vector3(currentx, 57.0f);
        }
       
    
    }
}
