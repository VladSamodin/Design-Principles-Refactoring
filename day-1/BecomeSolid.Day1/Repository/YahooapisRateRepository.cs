using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Repository
{
    class YahooapisRateRepository : IRateRepository
    {
        private const string urlPattern = "https://query.yahooapis.com/v1/public/yql?q=select+*+from+yahoo.finance.xchange+where+pair+=+%22{0}%22&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys&callback=";

        public string GetRateJson(IEnumerable<string> currencies)
        {
            string currenciesEnum = "";
            foreach (var currency in currencies)
            {
                currenciesEnum += "," + currency + "BYR";
            }
            currenciesEnum = currenciesEnum.Substring(1);
            WebUtility.UrlEncode(currenciesEnum);
            string url = string.Format(urlPattern, currenciesEnum);
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}
