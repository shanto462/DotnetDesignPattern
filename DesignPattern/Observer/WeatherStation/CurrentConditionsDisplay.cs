using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer.WeatherStation
{
    public class CurrentConditionsDisplay : ISubscriber
    {
        private WeatherData data;
        private readonly IPublisher weatherData;

        public CurrentConditionsDisplay(IPublisher weatherDataProvider)
        {
            weatherData = weatherDataProvider;
            weatherData.RegisterSubscriber(this);
        }

        public void Display()
        {
            Console.WriteLine(@"Current Conditions : Temp = {0} Deg | Humidity = {1}% | Pressure = {2} bar",
            data.Temperature, data.Humidity, data.Pressure);
        }

        public void Update(WeatherData data)
        {
            this.data = data;
            Display();
        }
    }
}
