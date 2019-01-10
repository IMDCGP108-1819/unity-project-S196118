using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {






    // If the enemy collides with the player then player losses health
    void OnCollisionEnter2D(Collision2D hit)
    {
     if (hit.gameObject.tag.Equals("Player"))
        {
            HealthBar.Health -= 10f;
        }  
    }

    // Enemy damage

    public int Health = 100;
    public void TakeDamage (int damage)
    {
        Health -= damage;

        if (Health <-0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

}
