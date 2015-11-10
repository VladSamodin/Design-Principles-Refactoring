using BecomeSolid.Day1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Service
{
    interface IWheatherService
    {
        WeatherMetricsContainer GetWeather(string cityName);
    }
}
