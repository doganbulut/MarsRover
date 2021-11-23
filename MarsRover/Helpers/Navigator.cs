using MarsRover.Entities;
using System;
using System.IO;

namespace MarsRover.Helpers
{
    public class Navigator
    {
        private readonly Compass compass;

        public Position Position { get; }

        public Surface Surface { get; }

        public event EventHandler<ErrorEventArgs> OnException;

        public Navigator(Surface surface, Position position)
        {
            compass = new Compass();
            this.Surface = surface;
            this.Position = position;
        }


        public void TurnLeft()
        {
            if (Position.D == 3)
                Position.D = 0;
            else
                ++Position.D;
        }


        public void TurnRight()
        {
            if (Position.D == 0)
                Position.D = 3;
            else
                --Position.D;
        }

        public bool TryMove()
        {
            //try
            //{
            var actualDirection = compass.Directions[Position.D];


            if (actualDirection.DestinationX != 0)
            {
                int simulatedPositionX = Position.X;
                simulatedPositionX += (actualDirection.DestinationX);
                if (XIsValid(simulatedPositionX))
                    Position.X = simulatedPositionX;
                else
                    return false;
            }
            else if (actualDirection.DestinationY != 0)
            {
                var simulatedPositionY = Position.Y;
                simulatedPositionY += (actualDirection.DestinationY);
                if (YIsValid(simulatedPositionY))
                    Position.Y = simulatedPositionY;
                else
                    return false;
            }

            return true;
            //}
            //catch (Exception e)
            //{
            //    OnException(this, new ErrorEventArgs(e));
            //    return false;
            //}
        }

        private bool XIsValid(int x)
        {
            if (x >= 0 && x <= Surface.X)
            {
                return true;
            }
            else
            {
                OnException?.Invoke(this, new ErrorEventArgs(new ArgumentOutOfRangeException(nameof(x), x, "The Rover position out of surface limit")));
                return false;
            }
        }

        private bool YIsValid(int y)
        {
            if (y >= 0 && y <= Surface.Y)
            {
                return true;
            }
            else
            {
                OnException?.Invoke(this, new ErrorEventArgs(new ArgumentOutOfRangeException(nameof(y), y, "The Rover position out of surface limit")));
                return false;
            }
        }

    }
}
