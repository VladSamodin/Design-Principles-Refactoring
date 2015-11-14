using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Parsers
{
    class WeatherArgumentsParser
    {
        public virtual WeatherArguments Parse(string arguments)
        {
            //string[] parts = arguments.Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
            //string city = parts[0];
            //DateTime date;
            //if (parts.Length == 1 || !DateTime.TryParse(parts[1], out date))
            //    date = DateTime.Today;
            //return new WeatherArguments { City = city, Date = date };

            string city = arguments ?? "Minsk"; // стоит ли тут задавать дефолтное значение?
            return new WeatherArguments { City = city };
        }
    }
}
