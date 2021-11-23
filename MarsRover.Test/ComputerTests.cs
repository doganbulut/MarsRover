using System.Collections.Generic;
using MarsRover.Entities;
using MarsRover.Enums;
using MarsRover.Helpers;
using MarsRover.Helpers.Command;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test
{
    [TestClass()]
    public class ComputerTests
    {
        [TestMethod()]
        public void CommandInvokeHelperTest()
        {
            // Arrange
            var navigator = new Navigator(new Surface(5, 5), new Position(0, 0, CompassDirections.N));
            var commands = new List<ICommand> { new TurnLeftCommand () };

            // Act
            Computer computer = new Computer(navigator, commands);

            // Assert
            Assert.AreEqual(1, computer.Commands.Count);
        }

        [TestMethod()]
        public void ExecuteAllTest()
        {
            // Arrange
            var navigator = new Navigator(new Surface(5, 5), new Position(0, 0, CompassDirections.N));
            var commands = new List<ICommand> { new TurnRightCommand (), new MoveCommand () };

            // Act
            var computer = new Computer(navigator, commands);
        
            // Assert
            Assert.IsTrue(computer.ExecuteAll());
        }
    }
}