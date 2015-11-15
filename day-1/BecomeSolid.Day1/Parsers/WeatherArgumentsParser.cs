using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Parsers
{
    class WeatherArgumentsParser : IWeatherArgumentsParser<WeatherArguments>
    {
        private string defaultCity;

        public WeatherArgumentsParser(string defaultCity)
        {
            this.defaultCity = defaultCity;
        }

        public WeatherArguments Parse(string arguments)
        {
            //string[] parts = arguments.Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
            //string city = parts[0];
            //DateTime date;
            //if (parts.Length == 1 || !DateTime.TryParse(parts[1], out date))
            //    date = DateTime.Today;
            //return new WeatherArguments { City = city, Date = date };

            string city = arguments ?? defaultCity; // стоит ли тут задавать дефолтное значение?
            return new WeatherArguments { City = city };
        }
    }
}
