using MarsRover.Entities;
using MarsRover.Helpers;
using System;
using System.IO;

namespace MarsRover
{
    public class Rover
    {
        public Computer Computer { get; }

        public Position Position
        {
            get { return Computer.Navigator.Position; }
        }

        public Rover(Computer computer)
        {
            Computer = computer;
            Computer.Navigator.OnException += Navigator_OnException;
        }

        private void Navigator_OnException(object sender, ErrorEventArgs e)
        {
            Console.WriteLine("Rover command canceled ! e:" + e.GetException().Message);
        }

        public bool Discover()
        {
            return Computer.ExecuteAll();
        }

    }
}
