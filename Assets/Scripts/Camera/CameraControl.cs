using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject player;

    void LateUpdate()
    {
        Vector3 playerPos = player.transform.position;
        playerPos.z = transform.position.z;
        transform.position = playerPos;
    }
}
