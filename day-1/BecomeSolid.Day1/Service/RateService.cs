using BecomeSolid.Day1.Models.Rate;
using BecomeSolid.Day1.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BecomeSolid.Day1.Service
{
    class RateService : IRateService<CurrencyInfo>
    {
        private IRateRepository repository;

        public RateService(IRateRepository repository)
        {
            this.repository = repository;
        }

        public CurrencyInfo GetRate(IEnumerable<string> currencies)
        {
            var rateJson = repository.GetRateJson(currencies);
            rateJson = rateJson.Replace("\"rate\":{", "\"rate\":[{");
            rateJson = rateJson.Replace("}}}}", "}]}}}");
            var currencyInfo = JsonConvert.DeserializeObject<CurrencyInfo>(rateJson);
            return currencyInfo;
        }
    }
}
