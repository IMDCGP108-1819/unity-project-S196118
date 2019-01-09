using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Enemy patroll (movement)






    // Enemy health
    public int Health = 100;
    public void TakeDamage (int Damage)
    {
        Health -= Damage;

        if (Health <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        Destroy(gameObject); 
    }
    
    // If player hits enemy - player lose 10 HP

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        Damage();
    }

    void Damage()
    {
       HealthBar.Health -= 10f;
    }

}

