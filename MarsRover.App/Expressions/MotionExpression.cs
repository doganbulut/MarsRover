using System;
using System.Text.RegularExpressions;

namespace MarsRover.App.Expressions
{
    public class MotionExpression
    {
        private readonly string pattern = @"^([LMR])+$";

        public string Commands { get; set; }

        public bool Validate(string commandText)
        {
            Commands = string.Empty;

            var m = Regex.Match(commandText, pattern);

            if (!m.Success)
            {
                Console.WriteLine("Rover motion command is not valid");
                return false;
            }
            
            Commands = commandText;

            return true;
        }
    }
}
