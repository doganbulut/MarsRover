using System.Collections.Generic;
using MarsRover.Entities;
using MarsRover.Enums;
using MarsRover.Helpers;
using MarsRover.Helpers.Command;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test
{
    [TestClass()]
    public class RoverTests
    {
        [TestMethod()]
        public void RoverTest()
        {
            // Arrange
            var navigator = new Navigator(new Surface(5, 5), new Position(0, 0, CompassDirections.N));
            var commands = new List<ICommand> { new TurnLeftCommand () };
            var computer = new Computer(navigator, commands);

            // Act
            var rover = new Rover(computer);

            // Assert
            Assert.IsNotNull(rover);
            Assert.IsNotNull(rover.Computer);
            Assert.IsNotNull(rover.Computer.Navigator);
            Assert.IsNotNull(rover.Position);
        }

        [TestMethod()]
        public void DiscoverTest()
        {
            // Arrange
            var navigator = new Navigator(new Surface(5, 5), new Position(0, 0, CompassDirections.N));
            var commands = new List<ICommand> { new TurnLeftCommand () };
            var computer = new Computer(navigator, commands);

            // Act
            var rover = new Rover(computer);

            // Assert
            Assert.IsNotNull(rover);
            Assert.IsNotNull(rover.Computer);
            Assert.IsNotNull(rover.Computer.Navigator);
            Assert.IsNotNull(rover.Position);
            Assert.IsTrue(rover.Discover());
        }

        [TestMethod()]
        public void DiscoverFailTest()
        {
            // Arrange
            var navigator = new Navigator(new Surface(5, 5), new Position(0, 0, CompassDirections.N));

            //CommandList
            var commands = new List<ICommand> {
                new TurnRightCommand (),
                new MoveCommand (),
                new MoveCommand (),
                new MoveCommand (),
                new MoveCommand (),
                new MoveCommand (),
                new MoveCommand (),
                new MoveCommand (),
                new MoveCommand ()
             };


            var computer = new Computer(navigator, commands);
            
            // Act
            var rover = new Rover(computer);
            
            // Assert
            Assert.IsFalse(rover.Discover());
        }
    }
}