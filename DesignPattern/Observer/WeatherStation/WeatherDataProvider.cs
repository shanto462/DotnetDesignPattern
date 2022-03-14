using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer.WeatherStation
{
    public class WeatherDataProvider : IPublisher
    {
        private List<ISubscriber> _subcribers;
        private WeatherData data;

        public WeatherDataProvider()
        {
            _subcribers = new List<ISubscriber>();
        }
        public void RegisterSubscriber(ISubscriber subscriber)
        {
            _subcribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            _subcribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (var sub in _subcribers)
            {
                sub.Update(data);
            }
        }

        private void MeasurementsChanged()
        {
            NotifySubscribers();
        }

        public void SetMeasurements(float temp, float humid, float pres)
        {
            data = new WeatherData(temp, humid, pres);
            MeasurementsChanged();
        }
    }
}
