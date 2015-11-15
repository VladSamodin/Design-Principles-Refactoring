using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Parsers.Interfaces
{
    interface IRateArgumentsParser <out T>
        where T : IRateArguments
    {
        T Parse(string arguments);
    }
}
