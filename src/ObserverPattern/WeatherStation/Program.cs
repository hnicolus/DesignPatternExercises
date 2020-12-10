using System;
using System.Collections.Generic;
using WeatherStation.Core.Interfaces;
using WeatherStation.Core.Models;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var forecastDisplay = new ForecastDisplay(weatherData);
            var statDisplay = new StatisticDisplay(weatherData);


            weatherData.Humidity = 46.67;
            weatherData.Pressure = 20.23;
            weatherData.Temperature = 15.54;

            var displays = new List<IDisplay>();

            displays.Add(forecastDisplay);
            displays.Add(statDisplay);

            weatherData.Humidity = 50.67;
            weatherData.Pressure = 67.23;
            weatherData.Temperature = 34.54;

            foreach (var display in displays)
            {
                display.Display();
            }
        }
    }
}
