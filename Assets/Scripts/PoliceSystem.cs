using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceSystem : MonoBehaviour
{
    public int wantedLevel;
    public float chaseDistance;

    // Start is called before the first frame update
    void Start()
    {
        wantedLevel = 0;
        chaseDistance = 50.0f;
    }

    // Update is called once per frame
    void Update()
    {
        CheckWantedLevel();
    }

    void CheckWantedLevel()
    {
        // Logic for updating wanted level based on player actions
        // Placeholder for demonstration
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            wantedLevel = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            wantedLevel = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            wantedLevel = 3;
        }

        // Trigger police chase based on wanted level
        if (wantedLevel > 0)
        {
            InitiatePoliceChase();
        }
    }

    void InitiatePoliceChase()
    {
        // Logic for police chase behavior
        // For demonstration, we can simply print to console
        Debug.Log("Police are chasing the player! Wanted Level: " + wantedLevel);
    }
}