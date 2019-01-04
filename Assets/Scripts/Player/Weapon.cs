using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform firepoint;
    public GameObject laserBeam;
	
    // Update is called once per frame
    // Shooting Mouse 1
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
	}
    //Shooting function
    void Shoot ()
    {
        Instantiate(laserBeam, firepoint.position, firepoint.rotation);
    }
}
