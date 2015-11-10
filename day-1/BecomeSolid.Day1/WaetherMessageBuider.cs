using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1
{
    public class WaetherMessageBuider
    {
        //private const string messagePattern = "In {0} {1} and the temperature is {2}°C";

        private string cityName;
        private string description;
        private double temperature;

        public WaetherMessageBuider SetCityName(string cityName)
        {
            this.cityName = cityName;
            return this;
        }

        public WaetherMessageBuider SetDescription(string description)
        {
            this.description = description;
            return this;
        }

        public WaetherMessageBuider SetTemperature(double temperature)
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

        //public string Build(string cityName, string description, double temperature)
        //{
        //    return String.Format(messagePattern, cityName, description, temperature.ToString("+#;-#"));
        //}
    }
}
