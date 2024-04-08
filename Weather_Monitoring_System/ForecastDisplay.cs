using System;

/// <summary>
/// Observer responsible for displaying weather forecast.
/// </summary>
public class ForecastDisplay : IDisplay
{
    public void Update(double temperature, double humidity, double pressure)
    {
        // Simulate forecast based on current weather data
        string forecast = "Sunny"; // Example forecast
        Console.WriteLine($"Forecast: {forecast}");
    }
}
