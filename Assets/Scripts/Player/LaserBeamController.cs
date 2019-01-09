using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeamController : MonoBehaviour
{
    public EnemyController script;
    public float speed = 40f;
    public Rigidbody2D rb;
    public int Damage = 100;
    

    // Laser Velocity
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

   public void OnTriggerEnter2D (Collider2D HitInfo)
   {
      EnemyController enemy = HitInfo.GetComponent<EnemyController>();
        if (enemy != null)
        {
            //EnemyController.TakeDamage(Damage);
        }
        Destroy(gameObject);
    }
   
}   
