using BecomeSolid.Day1.Builders;
using BecomeSolid.Day1.Models;
using BecomeSolid.Day1.Parsers;
using BecomeSolid.Day1.Repository;
using BecomeSolid.Day1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace BecomeSolid.Day1.Commands
{
    class WeatherCommand <T> : BotCommand
        where T : IWeatherMetrics
    {
        IWeatherService<T> service;
        IWeatherArgumentsParser<IWeatherArguments> parser;
        IWeatherMessageBuilder<T> messageBuilder;

        public WeatherCommand(Api bot
            , IWeatherService<T> service
            , IWeatherArgumentsParser<IWeatherArguments> parser
            , IWeatherMessageBuilder<T> messageBuilder) 
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
            var weatherMetrics = service.GetWeather(arguments.City);
            
            //var messageBuilder = new WeatherMessageBuider();
            //string message = messageBuilder
            //    .SetCityName(weatherMetrics.name)
            //    .SetDescription(weatherMetrics.weather.First().description)
            //    .SetTemperature(weatherMetrics.main.temp)
            //    .Build();
            string message = messageBuilder.Build(weatherMetrics);

            var t = await bot.SendTextMessage(update.Message.Chat.Id, message);
            Console.WriteLine("Echo Message: {0}", message);
        }

        //public override bool Applicable
        //{
        //    get { return true; }
        //}
    }
}
