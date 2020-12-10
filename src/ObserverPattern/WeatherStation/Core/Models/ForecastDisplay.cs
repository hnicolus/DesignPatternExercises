using System;
using System.Collections.Generic;
using WeatherStation.Core.Interfaces;

namespace WeatherStation.Core.Models
{

    public class ForecastDisplay : IObserver, IDisplay
    {
        private readonly ISubject _subject;
        private double _temperature;
        private double _humidity;
        private double _pressure;

        public ForecastDisplay( ISubject subject)
        {
            _subject = subject;
            subject.AddObserver(this);
            
        }
        public void Display()
        {
            Console.WriteLine("Forecast Display \n" + new string('=', 40));

            Console.WriteLine(
                $"Temperature : {_temperature}\n" +
                $"Humidity    : {_humidity}\n"+
                $"Pressure    : {_pressure}\n"
                );
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
        }
    }
}
