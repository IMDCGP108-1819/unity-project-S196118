using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private int score;

    // Jump control
    public Rigidbody2D rb;
    public float JumpForce = 5.0f;

    public float MaxSpeed = 8.0f;

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

    // Screen Binding - Left and Top
    private void LateUpdate()
    {
        float currentx = transform.position.x;
        float currenty = transform.position.y;

        if (currentx < -8.3f)
        {
            transform.position = new Vector3(-8.3f, transform.position.x);
        }
        if (currenty > 8.0f)
        {
            transform.position = new Vector3( 8.0f, transform.position.y);
        }
    }
}
   

