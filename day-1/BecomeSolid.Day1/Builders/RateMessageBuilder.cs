﻿using BecomeSolid.Day1.Builders.Interfaces;
using BecomeSolid.Day1.Models.Rate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Builders
{
    class RateMessageBuilder : IRateMessageBuilder<CurrencyInfo>
    {
        private const string messagePattern = "In {0} {1} and the temperature is {2}°C";

        public string Build(CurrencyInfo currnciesRate)
        {
            var result = "";
            foreach (var rate in currnciesRate.query.results.rate)
            {
                result += "\n\r" + rate.Name + " - " + rate.Rate;
            }
            if (String.IsNullOrEmpty(result))
                return result;  
            return result.Substring(2);
        }
    }
}
