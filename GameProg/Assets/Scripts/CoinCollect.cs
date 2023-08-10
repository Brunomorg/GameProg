using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    [SerializeField]private CoinManager _coinManager;
    // Called on Collision with Trigger
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        // If Game Object = Player
        if (other.gameObject.layer == 7)
        {
            _coinManager.OnCoinCollect();
            Destroy(gameObject);
        }
    }
}