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
    class WeatherCommand : BotCommand
    {
        IWeatherService service;

        public WeatherCommand(Api bot, IWeatherService service) : base(bot) 
        {
            this.service = service;
        }

        //public override async Task ExecuteAsync(string argumentsString, Update update)
        public override async Task ExecuteAsync(Dictionary<string, object> context)
        {
            var argumentsString = context["argumentsString"] as string;
            var update = context["update"] as Update;

            var parser = new WeatherArgumentsParser();
            var arguments = parser.Parse(argumentsString);

            //var service = new WeatherService(new OpenWeatherMapRepository());
            var weatherMetrics = service.GetWeather(arguments.City);

            var messageBuilder = new WaetherMessageBuider();

            string message = messageBuilder
                .SetCityName(weatherMetrics.name)
                .SetDescription(weatherMetrics.weather.First().description)
                .SetTemperature(weatherMetrics.main.temp)
                .Build();

            var t = await bot.SendTextMessage(update.Message.Chat.Id, message);
            Console.WriteLine("Echo Message: {0}", message);
        }

        //public override bool Applicable
        //{
        //    get { return true; }
        //}
    }
}
