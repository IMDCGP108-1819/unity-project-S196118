using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour
{
    // If the player collides with the player then player gains health
    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.tag.Equals("Player"))
        {
            HealthBar.Health += 10f;
        }
        Destroy(gameObject);
    }
}

   

