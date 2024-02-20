using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Behavioural.Command
{
    public class SmartHouseApp
    {
        private readonly List<SmartHouseCommandKey> Commands;
        public SmartHouseApp()
        {
            Commands = new List<SmartHouseCommandKey>();
        }

        public void AddCommand(string key, ISmartHouseCommand command)
        {
            if (Commands.Any(cmd => cmd.Key.Equals(key))) return;
            Commands.Add(new SmartHouseCommandKey(key, command));
        }

        public void ExecuteCommand(string key)
        {
            var command = Commands.Where(cmd => cmd.Key.Equals(key)).FirstOrDefault();
            command?.Command.Execute();
        }

        public void UndoCommand(string key)
        {
            var command = Commands.Where(cmd => cmd.Key.Equals(key)).FirstOrDefault();
            command?.Command.Undo();
        }
    }

    internal record SmartHouseCommandKey(string Key, ISmartHouseCommand Command);
}
