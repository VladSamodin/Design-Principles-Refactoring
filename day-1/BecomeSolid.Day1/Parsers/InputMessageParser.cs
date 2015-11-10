using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Parsers
{
    class InputMessageParser
    {
        public virtual InputMessage Parse(string inputString)
        {
            string[] parts = inputString.Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
            string command = parts[0];
            string arguments = parts.Length == 1 ? null : parts[1];
            return new InputMessage { Command = command, Arguments = arguments };
        }
    }
}
