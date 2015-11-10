using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace BecomeSolid.Day1.Commands
{
    class DefaultCommand : BotCommand
    {
        public DefaultCommand(Api bot) : base(bot) { }

        public override async Task ExecuteAsync(string argumentsString, Update update)
        {
            await bot.SendChatAction(update.Message.Chat.Id, ChatAction.Typing);
            await Task.Delay(2000);
            var t = await bot.SendTextMessage(update.Message.Chat.Id, update.Message.Text);
            Console.WriteLine("Echo Message: {0}", update.Message.Text);
        }

        public override bool Applicable
        {
            get { return true; }
        }
    }
}
