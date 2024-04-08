using System;

/// <summary>
/// Observer responsible for displaying current weather conditions.
/// Also acts as a decorator to add additional information.
/// </summary>
public class CurrentConditionsDisplay : IDisplay
{
    public void Update(double temperature, double humidity, double pressure)
    {
        Console.WriteLine($"Current Conditions: Temperature {temperature}, Humidity {humidity}, Pressure {pressure}");
    }
}
