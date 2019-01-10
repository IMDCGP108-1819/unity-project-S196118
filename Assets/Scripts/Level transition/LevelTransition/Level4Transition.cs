using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4Transition : MonoBehaviour
{

    // Upon collision load level 4
    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.tag.Equals("Player"))
        {
            SceneManager.LoadScene("Level4");
        }
    }
}

