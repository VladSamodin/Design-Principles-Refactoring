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
            string city = arguments ?? "Minsk"; // стоит ли тут задавать дефолтное значение?
            return new WeatherArguments { City = city };
        }
    }
}
