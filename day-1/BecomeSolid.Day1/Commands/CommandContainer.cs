using BecomeSolid.Day1.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace BecomeSolid.Day1
{
    class CommandContainer
    {
        private Dictionary<string, ICommand> commands;
        private ICommand defaultCommand;

        public CommandContainer(ICommand defaultCommand = null)
        {
            commands = new Dictionary<string, ICommand>();
            //Сделать проверку на null?
            this.defaultCommand = defaultCommand;
        }

        public void RegistreCommand(string name, ICommand type)
        {
            commands.Add(name, type);
        }

        public void RemoveCommand(string name)
        {
            commands.Remove(name);
        }

        public bool Contains(string name)
        {
            return commands.ContainsKey(name);
        }

        public ICommand GetCommand(string name)
        {
            if (!Contains(name))
                return defaultCommand;
            return commands[name];
        }
    }
}
