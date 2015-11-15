using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Repository
{
    interface IRateRepository
    {
        string GetRateJson(string cityName);
    }
}
