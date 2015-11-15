using BecomeSolid.Day1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeSolid.Day1.Builders
{
    interface IMessageBuilder <in T>
        where T : IEntity
    {
        string Build(T entity);
    }
}
