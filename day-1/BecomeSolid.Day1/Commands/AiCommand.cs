using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace BecomeSolid.Day1.Commands
{
    class AiCommand : BotCommand
    {
        public AiCommand(Api bot) : base(bot) { }

        //public override async Task ExecuteAsync(string arguments, Update update)
        public override async Task ExecuteAsync(Dictionary<string, object> context)
        {
            string arguments = context["argumentsString"] as string;
            Update update = context["update"] as Update;

            string command = arguments.Trim().ToLower();
            Regex pattern = new Regex(" {2,}");
            pattern.Replace(command, " ");

            switch (command)
            {
                case "как тебя зовут":
                    await SendMyName(update.Message.Chat.Id);
                    break;
                case "как дела":
                    
                    break;

                default:
                    await UnknownCommand(update.Message.Chat.Id);
                    break;
            }

        }

        public async Task SendMyName(int chatId)
        {
            var me = await bot.GetMe();
            var t = await bot.SendTextMessage(chatId, me.Username);
            Console.WriteLine("Echo Message: {0}", me.Username);
        }

        public async Task HowAreYou(int chatId)
        {

        }

        public async Task UnknownCommand(int chatId)
        {
            var message = "Я не понимаю тебя, постарайся выражаться яснее.";
            var t = await bot.SendTextMessage(chatId, message);
            Console.WriteLine("Echo Message: {0}", message);
        }

        //public override bool Applicable
        //{
        //    get { return true; }
        //}
    }
}
