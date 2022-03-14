using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer.WeatherStation
{
    public class WeatherData
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public WeatherData(float temp, float humid, float pres)
        {
            Temperature = temp;
            Humidity = humid;
            Pressure = pres;
        }
    }
}
