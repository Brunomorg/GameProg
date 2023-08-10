using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    
    // Player reference
    private GameObject player;


    private void Start()
    {
        // Check if there is a Game Object with Player tag
        player = GameObject.FindWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Checking if the entered Object is layer 7 = Player
        if (other.gameObject.layer == 7)
        {
            // Kill player
            Destroy(player);
            // Send message to console
            Debug.Log("Player ded");
        }
        
    }
}
