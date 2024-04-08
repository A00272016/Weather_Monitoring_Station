using System;

/// <summary>
/// Observer responsible for displaying weather statistics.
/// </summary>
public class StatisticsDisplay : IDisplay
{
    private double maxTemperature = double.MinValue;
    private double minTemperature = double.MaxValue;
    private double sumTemperature = 0;
    private int numReadings = 0;

    public void Update(double temperature, double humidity, double pressure)
    {
        // Update statistics
        maxTemperature = Math.Max(maxTemperature, temperature);
        minTemperature = Math.Min(minTemperature, temperature);
        sumTemperature += temperature;
        numReadings++;

        // Display statistics
        Console.WriteLine($"Statistics: Max Temperature {maxTemperature}, Min Temperature {minTemperature}, Average Temperature {sumTemperature / numReadings}");
    }
}
