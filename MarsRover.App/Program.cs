using MarsRover.App.Expressions;
using MarsRover.Entities;
using MarsRover.Helpers;
using System;

namespace MarsRover.App
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                var validator = new Validator();


                var sizeInput = Console.ReadLine();

                if (validator.Plateau.Validate(sizeInput))
                {

                    var plateau = new Plateau(validator.Plateau.X, validator.Plateau.Y);

                    while (true)
                    {
                        var positionInput= Console.ReadLine();

                        if (string.IsNullOrEmpty(positionInput))//break and discover
                            break;

                        if (validator.Position.Validate(positionInput) && (validator.Position.CheckSurface(plateau.Surface)))
                        {

                            var position = new Position
                            (
                                validator.Position.X,
                                validator.Position.Y,
                                validator.Position.D
                            );

                            var navigator = new Navigator(plateau.Surface, position);

                            var motionInput = Console.ReadLine();

                            if (validator.Motion.Validate(motionInput))
                            {
                                var commands = validator.Motion.Commands;
                                var computer = new Computer(navigator, commands);
                                var rover = new Rover(computer);
                                plateau.AddRover(rover);
                            }
                        }
                    }

                    //Discover
                    foreach (Rover rover in plateau.Rovers)
                    {
                        rover.Discover();
                        Console.WriteLine(rover.Position.ToString());
                    }


                    Console.WriteLine("Do you want to restart command line ? (Y/N)");
                    var input = Console.ReadLine();

                    if (input != null && input.Equals("Y", StringComparison.OrdinalIgnoreCase))
                        Console.Clear();//Restart
                    else
                        break;//Exit
                    

                }

            }

        }
    }
}
