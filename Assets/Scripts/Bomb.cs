using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Bomb triggered by {other.gameObject.name}");

        // Check what the bomb collided with
        // In case the object is the enemy
        if (other.CompareTag("Enemy"))
        {
            // Log message to console
            Debug.Log("Enemy hit by bomb!");

            // Destroy the enemy
            Destroy(other.gameObject);
        }

        // Destroy the bomb
        Destroy(gameObject);
    }
}
