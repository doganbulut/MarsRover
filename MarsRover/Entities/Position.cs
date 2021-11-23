using MarsRover.Enums;

namespace MarsRover.Entities
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int D { get; set; }

        public Position(int x, int y, CompassDirections d)
        {
            this.X = x;
            this.Y = y;
            this.D = (int)d;
        }


        public override string ToString()
        {
            return $"{X} {Y} {(CompassDirections)D}";
        }

    }
}
