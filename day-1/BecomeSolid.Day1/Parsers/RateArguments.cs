using BecomeSolid.Day1.Parsers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Parsers
{
    class RateArguments : IRateArguments
    {
        public IEnumerable<string> Currencies { get; set; }
    }
}
