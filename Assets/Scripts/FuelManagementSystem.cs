using UnityEngine;

public class FuelManagementSystem : MonoBehaviour
{
    private float fuelLevel;
    private const float maxFuelCapacity = 100f;
    private const float fuelConsumptionRate = 1f; // Fuel consumed per second

    void Start()
    {
        fuelLevel = maxFuelCapacity; // Start with full fuel
    }

    void Update()
    {
        if (fuelLevel > 0)
        {
            ConsumeFuel();
        }
        else
        {
            OutOfFuel();
        }
    }

    private void ConsumeFuel()
    {
        fuelLevel -= fuelConsumptionRate * Time.deltaTime;
        fuelLevel = Mathf.Max(fuelLevel, 0);
        Debug.Log("Fuel Level: " + fuelLevel);
    }

    public void Refuel(float amount)
    {
        fuelLevel += amount;
        fuelLevel = Mathf.Min(fuelLevel, maxFuelCapacity);
        Debug.Log("Refueled! New Fuel Level: " + fuelLevel);
    }

    private void OutOfFuel()
    {
        Debug.Log("Out of fuel! Please refuel.");
        // Implement additional logic for what happens when out of fuel
    }
}