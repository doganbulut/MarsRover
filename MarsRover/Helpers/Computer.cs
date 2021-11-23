using MarsRover.Helpers.Command;
using System;
using System.Collections.Generic;

namespace MarsRover.Helpers
{
    public class Computer
    {
        public IList<ICommand> Commands { get; }
        public Navigator Navigator { get; }

        public Computer(Navigator navigator, IList<ICommand> commands)
        {
            Navigator = navigator;
            Commands = commands;
        }

        public Computer(Navigator navigator, string commands)
        {
            Navigator = navigator;
            Commands = new List<ICommand>();

            foreach (char c in commands)
            {
                switch (c)
                {
                    case 'L':
                        Commands.Add(new TurnLeftCommand());
                        break;
                    case 'R':
                        Commands.Add(new TurnRightCommand());
                        break;
                    case 'M':
                        Commands.Add(new MoveCommand());
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }


        }

        public bool ExecuteAll()
        {
            foreach (var command in Commands)
                if (!command.Execute(Navigator))
                    return false;

            return true;
        }

    }
}
