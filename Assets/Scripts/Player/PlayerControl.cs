using UnityEngine;

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

    // Jump Limiter
     
    private float MaxJumpDist = 9.0f;
    public float JumpDist = position.y
   
    if (currenty = < 9.0f)
        transform.position = new Vector3(9.0f, Transform.position.y);



    // Screen Binding - Left
    private void LateUpdate()
    {
        float currentx = transform.position.x;

        if (currentx < -8.3f)
        {
            transform.position = new Vector3(-8.3f, transform.position.x);
        }



        // Shooting function
        {

        }
    }

}