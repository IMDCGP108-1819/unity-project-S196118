using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VictoryTransition : MonoBehaviour
{
    // Upon collision load level Voctory

    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.tag.Equals("Player"))
        {
            SceneManager.LoadScene("VictoryScreen");
        }
    }
}


