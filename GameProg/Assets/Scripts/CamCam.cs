using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CamCam : MonoBehaviour
{
    private Transform playerTransform;
    private float playerMaxY;

    private void Start()
    {
        playerTransform = GameObject.FindWithTag("Player").transform;
        playerMaxY = playerTransform.position.y;
    }
    
    
    private void Update()
    {
        if (playerTransform.position.y > playerMaxY)
        {
            playerMaxY = playerTransform.position.y;
        }
        
        transform.position = new Vector3(playerTransform.position.x, playerMaxY,
            playerTransform.position.z - 10);
    }
}