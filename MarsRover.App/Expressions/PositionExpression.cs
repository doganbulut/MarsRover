using MarsRover.Entities;
using MarsRover.Enums;
using System;
using System.Text.RegularExpressions;

namespace MarsRover.App.Expressions
{
    public class PositionExpression
    {
        private readonly string pattern = @"^([0-9]+) ([0-9]+) ([N,E,S,W])+$";

        public int X { get; set; }

        public int Y { get; set; }

        public CompassDirections D { get; set; }

        public bool Validate(string commandText)
        {
            var match = Regex.Match(commandText, pattern);

            if (match.Success)
            {
                X = int.Parse(match.Groups[1].Value);
                Y = int.Parse(match.Groups[2].Value);
                D = (CompassDirections)Enum.Parse(typeof(CompassDirections), match.Groups[3].Value);

                return true;
            }
            else
            {
                Console.WriteLine("Rover position is not valid!");
                return false;
            }
        }

        public bool CheckSurface(Surface surface)
        {
            var availLand = (X >= 0) && (X <= surface.X) && (Y >= 0) && (Y <= surface.Y);
            if (!availLand)
                Console.WriteLine("Rover position not available!");

            return availLand;
        }


    }
}
