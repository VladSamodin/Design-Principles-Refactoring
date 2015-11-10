using BecomeSolid.Day1.Parsers;
using BecomeSolid.Day1.Repository;
using BecomeSolid.Day1.Service;
using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace BecomeSolid.Day1.Commands
{
    class WeatherCommand : BotCommand
    {
        public WeatherCommand(Api bot) : base(bot) { }

        public override async Task ExecuteAsync(string argumentsString, Update update)
        {
            var parser = new WeatherArgumentsParser();
            var arguments = parser.Parse(argumentsString);

            var service = new WheatherService(new OpenWeatherMapRepository());
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
