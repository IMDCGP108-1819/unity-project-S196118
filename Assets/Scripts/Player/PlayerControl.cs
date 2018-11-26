using UnityEngine;

public class PlayerControl : MonoBehaviour {
    private int score;

    // jump control
    public float JumpCheckPosition;
    public float JumpCheckRange = 1.0f;

    public float MaxSpeed;

    // Player Movement
    void Update()
    {   
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.position = new Vector3(transform.position.x + horizontal * MaxSpeed, transform.position.y + vertical * MaxSpeed);
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

 
