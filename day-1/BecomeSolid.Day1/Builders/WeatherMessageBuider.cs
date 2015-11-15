using BecomeSolid.Day1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Builders
{
    public class WeatherMessageBuider : IWeatherMessageBuilder<WeatherMetricsContainer>
    {
        private const string messagePattern = "In {0} {1} and the temperature is {2}°C";

        private string cityName;
        private string description;
        private double temperature;

        public WeatherMessageBuider SetCityName(string cityName)
        {
            this.cityName = cityName;
            return this;
        }

        public WeatherMessageBuider SetDescription(string description)
        {
            this.description = description;
            return this;
        }

        public WeatherMessageBuider SetTemperature(double temperature)
        {
            this.temperature = temperature;
            return this;
        }

        public string Build()
        {
            var message = new StringBuilder();
            if (!String.IsNullOrEmpty(cityName))
            {
                message.AppendFormat("In {0} ", cityName);
            }
            if (!String.IsNullOrEmpty(description))
            {
                message.AppendFormat("{0} ", description);
            }
            message.AppendFormat("{0}", temperature.ToString("+#;-#"));
            return message.ToString();
        }

        public string Build(WeatherMetricsContainer weatherMetrics)
        {
            return String.Format(messagePattern, weatherMetrics.name, weatherMetrics.weather.First().description, weatherMetrics.main.temp.ToString("+#;-#"));
        }
    }
}
