using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Parsers
{
    interface IWeatherArgumentsParser <out T> 
        where T : IWeatherArguments
    {
        T Parse(string arguments);
    }
}
