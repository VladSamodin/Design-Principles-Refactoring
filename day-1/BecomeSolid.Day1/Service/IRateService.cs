using BecomeSolid.Day1.Models.Rate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Service
{
    interface IRateService <out T>
        where T : ICurrencyInfo
    {
        T GetRate(IEnumerable<string> currencies);
    }
}
