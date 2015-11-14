using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace BecomeSolid.Day1.Commands
{
    abstract class BotCommand : ICommand
    {
        protected Api bot;

        abstract public Task ExecuteAsync(Dictionary<string, object> context);

        public BotCommand(Api bot)
        {
            this.bot = bot;
        }

        //abstract public bool Applicable { get; }
    }
}
