﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class KillBox : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Level1");
    }
}
	
