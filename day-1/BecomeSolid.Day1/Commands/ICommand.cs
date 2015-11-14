using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace BecomeSolid.Day1.Commands
{
    interface ICommand
    {
        //Task ExecuteAsync(string arguments, Update update);
        Task ExecuteAsync(Dictionary<string, object> context);
        //bool Applicable { get; }
    }
}
