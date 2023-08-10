using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Kollison!");
        Debug.Log(other.gameObject.layer);

        if (other.gameObject.layer == 7) {
            
        }
    }
} 
