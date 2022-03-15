using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer.WeatherStation
{
    public class ForecastDisplay : ISubscriber, IDisposable
    {
        private WeatherData data;
        private readonly IPublisher weatherData;

        public ForecastDisplay(IPublisher weatherDataProvider)
        {
            weatherData = weatherDataProvider;
            weatherData.RegisterSubscriber(this);
        }

        public void Display()
        {
            Console.WriteLine(@"Forecast Conditions : Temp = {0}Deg | Humidity = {1}% | Pressure = {2} bar", data.Temperature + 6, data.Humidity + 20, data.Pressure - 3);
        }

        public void Update(WeatherData data)
        {
            this.data = data;
            Display();
        }

        public void Dispose()
        {
            weatherData.RemoveSubscriber(this);
        }
    }
}
