using System;
using MarsRover.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    public class Plateau
    {
        public Surface Surface { get; }
        public IList<Rover> Rovers { get; }

        public Plateau(int x, int y)
        {
            Surface = new Surface(x, y);
            Rovers = new List<Rover>();
        }

        public void AddRover(Rover rover)
        {
            var detectRover = Rovers.FirstOrDefault(p => p.Position.X == rover.Position.X && p.Position.Y == rover.Position.Y);
            if (detectRover == null)
                Rovers.Add(rover);
            else
                Console.WriteLine("There are other rover on this position: " + detectRover.Position);
            
        }
    }
}
