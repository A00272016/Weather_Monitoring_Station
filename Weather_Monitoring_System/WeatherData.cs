using System;
using System.Collections.Generic;

/// <summary>
/// Singleton class responsible for collecting weather data and notifying observers.
/// </summary>
public sealed class WeatherData
{
    private static readonly WeatherData instance = new WeatherData();
    private Random random = new Random();

    private WeatherData() { }

    public static WeatherData Instance => instance;

    private double temperature;
    private double humidity;
    private double pressure;

    // Method to generate random weather data
    public void GenerateRandomData()
    {
        temperature = random.NextDouble() * 100;
        humidity = random.NextDouble() * 100;
        pressure = random.NextDouble() * 100;
        NotifyObservers();
    }

    private List<IDisplay> displays = new List<IDisplay>();

    public void RegisterObserver(IDisplay display)
    {
        displays.Add(display);
    }

    public void RemoveObserver(IDisplay display)
    {
        displays.Remove(display);
    }

    public void NotifyObservers()
    {
        foreach (var display in displays)
        {
            display.Update(temperature, humidity, pressure);
        }
    }
}
