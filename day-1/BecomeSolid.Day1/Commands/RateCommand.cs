using BecomeSolid.Day1.Builders.Interfaces;
using BecomeSolid.Day1.Models.Rate;
using BecomeSolid.Day1.Parsers.Interfaces;
using BecomeSolid.Day1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace BecomeSolid.Day1.Commands
{
    class RateCommand <T> : BotCommand
        where T : ICurrencyInfo
    {
        IRateArgumentsParser<IRateArguments> parser;
        IRateService<T> service;
        IRateMessageBuilder<T> messageBuilder;

        public RateCommand(Api bot
            , IRateService<T> service
            , IRateArgumentsParser<IRateArguments> parser
            , IRateMessageBuilder<T> messageBuilder)
            : base(bot)
        {
            this.service = service;
            this.parser = parser;
            this.messageBuilder = messageBuilder;
        }

        public override async Task ExecuteAsync(Dictionary<string, object> context)
        {
            var argumentsString = context["argumentsString"] as string;
            var update = context["update"] as Update;

            var arguments = parser.Parse(argumentsString);
            var rates = service.GetRate(arguments.Currencies);

            string message = messageBuilder.Build(rates);

            var t = await bot.SendTextMessage(update.Message.Chat.Id, message);
            Console.WriteLine("Echo Message: {0}", message);
        }
    }
}
