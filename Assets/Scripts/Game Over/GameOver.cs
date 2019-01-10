using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour

{
    // load scene 1
    public void Reload()
    {
        SceneManager.LoadScene("Level1");
    }
    // return to menu
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

