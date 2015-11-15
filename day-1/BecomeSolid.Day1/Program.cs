using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using BecomeSolid.Day1.Commands;
using BecomeSolid.Day1.Parsers;
using System.Collections.Generic;
using BecomeSolid.Day1.Service;
using BecomeSolid.Day1.Repository;
using BecomeSolid.Day1.Builders;
using BecomeSolid.Day1.Models;

namespace BecomeSolid.Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Run().Wait();
        }

        static async Task Run()
        {
            var bot = new Api("145582668:AAEmRBxWzopyLmjniOw3SCshn1gdL4JcZEw");
            var me = await bot.GetMe();

            Console.WriteLine("Hello my name is {0}", me.Username);

            var offset = 0;
            var commandContainer = new CommandContainer(new DefaultCommand(bot));
            InitCommandContainer(commandContainer, bot);

            while (true)
            {
                var updates = await bot.GetUpdates(offset);

                foreach (var update in updates)
                {
                    if (update.Message.Type == MessageType.TextMessage)
                    {
                        var inputParser = new InputMessageParser();
                        var inputMessage = inputParser.Parse(update.Message.Text);                        

                        var command = commandContainer.GetCommand(inputMessage.Command);
                        var context = new Dictionary<string, object> {
                            {"argumentsString", inputMessage.Arguments},
                            {"update", update}
                        };
                        await command.ExecuteAsync(context);

                        //await command.ExecuteAsync(inputMessage.Arguments, update); // всегда выполняется дефолтное действие
                                                                                    // получится ли с помощью такого контекста все выполнять в цикле
                    }

                    offset = update.Id + 1;
                }

                await Task.Delay(1000);
            }
        }

        static void InitCommandContainer(CommandContainer CommandContainer, Api bot)
        {
            CommandContainer.RegistreCommand("/weather"
                , new WeatherCommand<WeatherMetricsContainer>(bot
                    , new WeatherService(new OpenWeatherMapRepository())
                    , new WeatherArgumentsParser("Minsk")
                    , new WeatherMessageBuider()
                )
            );
        }

    }
}
