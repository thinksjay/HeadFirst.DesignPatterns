using System;

namespace HeadFirst.DesignPatterns.Observer
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float _currentPressure = 29.92f;
        private float _lastPressure;
        private readonly WeatherData _weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _lastPressure = _currentPressure;
            _currentPressure = pressure;

            Display();
        }

        public void Display()
        {
            Console.Write("Forecast: ");
            if (_currentPressure > _lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (_currentPressure == _lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (_currentPressure < _lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }
    }
}