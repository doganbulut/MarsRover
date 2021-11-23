using System.Collections.Generic;

namespace MarsRover.Entities
{
    public class Compass
    {
        public IList<Direction> Directions { get; }

        public Compass()
        {
            Directions = new List<Direction>(4)
            {
                new Direction { Name = "N", DestinationX = 0, DestinationY = 1 },
                new Direction { Name = "W", DestinationX = -1, DestinationY = 0 },
                new Direction { Name = "S", DestinationX = 0, DestinationY = -1 },
                new Direction { Name = "E", DestinationX = 1, DestinationY = 0 }
            };
        }


    }
}
