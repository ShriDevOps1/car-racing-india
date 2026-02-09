// ShopSystem.cs - Handles various shops in the car racing environment

using System;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{
    // List of available shops
    private List<Shop> shops = new List<Shop>();

    void Start()
    {
        InitializeShops(); // Initialize the shops when the game starts
    }

    private void InitializeShops()
    {
        // Adding fuel stations
        shops.Add(new Shop("Fuel Station", "Refuel your car here", ShopType.FuelStation));

        // Adding repair shops
        shops.Add(new Shop("Repair Shop", "Get your car repaired here", ShopType.RepairShop));

        // Adding tire shops
        shops.Add(new Shop("Tire Shop", "Change your tires here", ShopType.TireShop));

        // Adding restaurants
        shops.Add(new Shop("Restaurant", "Refresh yourself before the race", ShopType.Restaurant));
    }

    // Method to get available shops
    public List<Shop> GetAvailableShops()
    {
        return shops;
    }
}

// Enum for shop types
public enum ShopType
{
    FuelStation,
    RepairShop,
    TireShop,
    Restaurant
}

// Shop class definition
[System.Serializable]
public class Shop
{
    public string Name;
    public string Description;
    public ShopType Type;

    public Shop(string name, string description, ShopType type)
    {
        Name = name;
        Description = description;
        Type = type;
    }
}