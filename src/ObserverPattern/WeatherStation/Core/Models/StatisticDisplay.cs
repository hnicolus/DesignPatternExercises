using System;
using System.Linq;
using WeatherStation.Core.Interfaces;

namespace WeatherStation.Core.Models
{
    public class StatisticDisplay : IObserver, IDisplay
    {
        private readonly ISubject _subject;
        private double _temperature;
        private double _humidity;
        private double _pressure;

        public StatisticDisplay(ISubject subject)
        {
            _subject = subject;
            subject.AddObserver(this);
        }
        public void Display()
        {
            double min= 0.0;
            double max = 0.0;
            var readings = new double[] { _temperature, _humidity, _pressure };

            for (int i = 0; i < readings.Length; i++)
            {
                if (i+1 >= readings.Length) break;
               min =  readings.Min();
                max = readings.Max();
                
            }

            double average = readings.Sum() / readings.Length;
            Console.WriteLine("Statistic Display \n" + new string('=', 40));
            Console.WriteLine($"Min : {min}\nMax : {max}\nAverage :{Math.Round(average, 2)}" );            
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
        }
    }
}
