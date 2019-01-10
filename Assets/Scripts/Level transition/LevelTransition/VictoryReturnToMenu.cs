using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryReturnToMenu : MonoBehaviour {
    // Returns to menu
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
