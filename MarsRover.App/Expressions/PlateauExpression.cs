using System;
using System.Text.RegularExpressions;

namespace MarsRover.App.Expressions
{
    public class PlateauExpression
    {
        private readonly string pattern = @"^([0-9]+) ([0-9]+)+$";

        public int X { get; set; }

        public int Y { get; set; }

        public bool Validate(string commandText)
        {
            var match = Regex.Match(commandText, pattern);

            if (match.Success)
            {
                X = int.Parse(match.Groups[1].Value);
                Y = int.Parse(match.Groups[2].Value);
                return true;
            }
            else 
            {
                Console.WriteLine("Plateau size is not valid");
                return false;
            }
        }
    }
}
