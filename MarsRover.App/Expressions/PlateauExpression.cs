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
                if (int.TryParse(match.Groups[1].Value, out var x))
                {
                    X = x;
                }
                else
                {
                    Console.WriteLine("Plateau X size is not valid");
                    return false;
                }

                if (int.TryParse(match.Groups[2].Value, out var y))
                {
                    Y = y;
                }
                else
                {
                    Console.WriteLine("Plateau Y size is not valid");
                    return false;
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
