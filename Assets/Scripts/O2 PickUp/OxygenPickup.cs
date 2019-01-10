using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenPickup : MonoBehaviour
{
    // If the player collides with the pickup then player gains 02
    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.tag.Equals("Player"))
        {
          Oxygen.oxygen += 25f; 
        }
        Destroy(gameObject);
    }
}

