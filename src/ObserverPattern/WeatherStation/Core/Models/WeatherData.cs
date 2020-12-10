using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Core.Interfaces;

namespace WeatherStation.Core.Models
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        private double _temperature = 0.0;
        private double _humidity = 0.0;
        private double _pressure = 0.0;

        public double Temperature
        {
            get => _temperature;
            set
            {
                _temperature = value;
                NotifyObservers();
            }
        }
        public double Humidity
        {
            get => _humidity;
            set
            {
                _humidity = value;
                NotifyObservers();
            }
        }
        public double Pressure
        { get => _pressure;
            set
            {
                _pressure = value;
                NotifyObservers();
            }
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
