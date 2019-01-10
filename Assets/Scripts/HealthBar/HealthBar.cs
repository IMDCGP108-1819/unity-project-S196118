using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour

{

    Image healthBar;
    float MaxHealth = 100f;
    public static float Health;

	// Use this for initialization
	void Start () {
        healthBar = GetComponent<Image>();
        Health = MaxHealth;
	}
	
	// If healthbar is empty load game over
	void Update ()
    {
        healthBar.fillAmount = Health / MaxHealth;

        if (healthBar.fillAmount == 0f)
        {
            SceneManager.LoadScene("Game Over Screen");
        }

	}
}
