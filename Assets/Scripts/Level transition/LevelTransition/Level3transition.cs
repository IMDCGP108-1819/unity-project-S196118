using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level3transition : MonoBehaviour
{
    
    // Upon collision load level 3
    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.tag.Equals("Player"))
        {
            SceneManager.LoadScene("Level3");
        }
    }
}


   