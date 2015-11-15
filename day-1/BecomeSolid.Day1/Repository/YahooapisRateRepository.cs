using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Repository
{
    class YahooapisRateRepository : IRateRepository
    {
        private const string urlPattern = "https://query.yahooapis.com/v1/public/yql?q=select+*+from+yahoo.finance.xchange+where+pair+=+%22{0}BYR%22&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys&callback=";

        public string GetRateJson(string cityName)
        {
            throw new NotImplementedException();
        }
    }
}
