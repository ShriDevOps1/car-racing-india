using System;
using UnityEngine;

public class AccidentSystem : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            HandleAccident(collision);
        }
    }

    void HandleAccident(Collision collision)
    {
        // Logic for handling accident when a collision occurs
        Debug.Log("Accident occurred with: " + collision.gameObject.name);
        // Additional accident handling code can be added here
    }
}