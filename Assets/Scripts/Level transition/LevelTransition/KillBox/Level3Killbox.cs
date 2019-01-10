using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Killbox : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Level3");
    }
}
