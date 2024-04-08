using System;

namespace WeatherMonitoringApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create WeatherData instance
            WeatherData weatherData = WeatherData.Instance;

            // Create and register display objects
            IDisplay currentConditionsDisplay = WeatherStation.CreateDisplay(DisplayType.CurrentConditions);
            weatherData.RegisterObserver(currentConditionsDisplay);

            IDisplay statisticsDisplay = WeatherStation.CreateDisplay(DisplayType.Statistics);
            weatherData.RegisterObserver(statisticsDisplay);

            IDisplay forecastDisplay = WeatherStation.CreateDisplay(DisplayType.Forecast);
            weatherData.RegisterObserver(forecastDisplay);

            // Simulate weather data changes
            weatherData.GenerateRandomData();

            // Simulate weather data changes again
            weatherData.GenerateRandomData();

            // Continue simulating weather data changes as needed

            Console.ReadLine(); // Wait for user input before closing the console window
        }
    }
}
