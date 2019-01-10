using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Oxygen : MonoBehaviour
{

    Image O2Bar;
    float MaxO2 = 250f;
    public static float oxygen;

    // Use this for initialization
    void Start()
    {
        O2Bar = GetComponent<Image>();
        oxygen = MaxO2;
    }

    // If 02 Bar is empty load game over
    void Update()
    {
        O2Bar.fillAmount = oxygen / MaxO2;

        if (O2Bar.fillAmount == 0f)
        {
            SceneManager.LoadScene("Game Over Screen");
        }

        // 02 Depletion
        oxygen-= 0.1f;
    }
}
