using BecomeSolid.Day1.Parsers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Parsers
{
    class RateArgumentsParser : IRateArgumentsParser<RateArguments>
    {

        public RateArguments Parse(string arguments)
        {
            var parts = arguments.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            return new RateArguments
            {
                Currencies = parts.Select(part => part.Trim())
            };
        }
    }
}
