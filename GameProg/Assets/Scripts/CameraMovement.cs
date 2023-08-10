using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Rigidbody2D playerRB;
    private Rigidbody2D cameraRB;
    private Transform lastPosition;
    private Vector3 lastPositionPosition;
    private void Start()
    {
        playerRB = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
        cameraRB = GetComponent<Rigidbody2D>();
        lastPosition = transform;
        lastPositionPosition = lastPosition.position;
    }
    
    public float GetMax(float value1, float value2)
    {
        return value1 > value2 ? value1 : value2;
    }
    
    private void Update()
    {
        //Debug.Log(player.GetComponent<Rigidbody2D>().velocity.y);
        if (playerRB.velocity.y < 0)
        {
            cameraRB.constraints |= RigidbodyConstraints2D.FreezePositionY;
            transform.position = new Vector3(transform.position.x, lastPositionPosition.y, transform.position.z);
        }
        else if (playerRB.velocity.y > 0)
        {
            lastPositionPosition.y = GetMax(transform.position.y, lastPositionPosition.y);
            Debug.Log(lastPositionPosition);
            cameraRB.constraints = RigidbodyConstraints2D.None;
        }
    }
}
