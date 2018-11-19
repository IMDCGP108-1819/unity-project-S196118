using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    // Player Movement
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

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

	
