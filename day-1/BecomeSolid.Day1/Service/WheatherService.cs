using BecomeSolid.Day1.Models;
using BecomeSolid.Day1.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Service
{
    class WheatherService : IWheatherService
    {
        IWheatherRepository repository;

        public WheatherService(IWheatherRepository repository)
        {
            this.repository = repository;
        }

        public WeatherMetricsContainer GetWeather(string cityName)
        {
            var weatherJson = repository.GetWheaterJson(cityName);
            var weatherContainer = JsonConvert.DeserializeObject<WeatherMetricsContainer>(weatherJson);
            return weatherContainer;
        }
    }
}
