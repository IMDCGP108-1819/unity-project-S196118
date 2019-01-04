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



    // flip Character - depending on direction

    private bool FacingRight;
    private bool FacingLeft;
    private void Flip()

    {
        { FacingRight = Input.GetButtonDown("right");

         if Input.GetButtonDown("right") = true)

                (transform.Rotate(0f, 180f, 0f)

         if Input.GetButtonDown("right") = false)

                (transform.Rotate(0f, 0f, 0f);
        }
        { FacingLeft = Input.GetButtonDown("Left");

         if Input.GetButtonDown("Left") = true)

                (transform.Rotate(0f, 180f, 0f)

         if Input.GetButtonDown("Left") = false)

                (transform.Rotate(0f, 0f, 0f);

        }
    }
    






    // Screen Binding - Left and jump limit
    private void LateUpdate()
    {
        float currentx = transform.position.x;

        if (currentx < -8.3f)
        {
            transform.position = new Vector3(-8.3f, transform.position.x);
        }

        // Shooting function - Prefab
        {

        }
    }
}
