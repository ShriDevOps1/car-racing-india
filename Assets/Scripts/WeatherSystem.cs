using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherSystem : MonoBehaviour
{
    public enum WeatherType { Sunny, Rainy, Winter }
    public WeatherType currentWeather;

    void Start()
    {
        SetWeather(WeatherType.Sunny); // Default weather
    }

    public void SetWeather(WeatherType newWeather)
    {
        currentWeather = newWeather;
        switch (currentWeather)
        {
            case WeatherType.Sunny:
                // Configure sunny weather dynamics
                Debug.Log("Weather is sunny.");
                break;
            case WeatherType.Rainy:
                // Configure rainy weather dynamics
                Debug.Log("Weather is rainy.");
                break;
            case WeatherType.Winter:
                // Configure winter weather dynamics
                Debug.Log("Weather is winter.");
                break;
        }
    }
}