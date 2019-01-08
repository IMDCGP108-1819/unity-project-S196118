using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Enemy Damage to player

    void OnTriggerEnter2D(Collider2D collision)
    {
        HealthBar.Health -= 10f;
    }
}

