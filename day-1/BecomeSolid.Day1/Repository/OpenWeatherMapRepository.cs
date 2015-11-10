using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Repository
{
    class OpenWeatherMapRepository : IWheatherRepository
    {
        private const string urlPattern = "http://api.openweathermap.org/data/2.5/weather?q={0}&APPID={1}&units=metric";
        private const string weatherApiKey = "ec259b32688dc1c1d087ebc30cbff9ed";

        public string GetWheaterJson(string cityName)
        {
            WebUtility.UrlEncode(cityName);
            string url = string.Format(urlPattern, cityName, weatherApiKey);
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}
