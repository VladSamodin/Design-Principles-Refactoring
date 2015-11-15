using BecomeSolid.Day1.Models.Rate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Builders.Interfaces
{
    interface IRateMessageBuilder <in T> : IMessageBuilder<T>
        where T : ICurrencyInfo
    {
    }
}
