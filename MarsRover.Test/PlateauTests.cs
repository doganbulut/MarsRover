using MarsRover.Entities;
using MarsRover.Enums;
using MarsRover.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test
{
    [TestClass()]
    public class PlateauTests
    {
        [TestMethod()]
        public void PlateauTest()
        {
            // Arrange
            var plateau = new Plateau(5, 5);
            // Act

            // Assert
            Assert.IsNotNull(plateau);
        }

        [TestMethod()]
        public void AddRoverTest()
        {
            // Arrange
            var plateau = new Plateau(5, 5);
            var navigator = new Navigator(new Surface(5, 5), new Position(0, 0, CompassDirections.N));
            var computer = new Computer(navigator, "LLL");
            var rover = new Rover(computer);

            // Act
            plateau.AddRover(rover);

            // Assert
            Assert.IsNotNull(plateau.Rovers);
            Assert.AreEqual(1, plateau.Rovers.Count);
        }

        [TestMethod()]
        public void AddRoverFailTest()
        {
            // Arrange
            var plateau = new Plateau(5, 5);
            var navigator = new Navigator(new Surface(5, 5), new Position(0, 0, CompassDirections.N));
            var computer = new Computer(navigator, "LLL");
            var rover = new Rover(computer);

            // Act
            plateau.AddRover(rover);
            plateau.AddRover(rover);

            // Assert
            Assert.IsNotNull(plateau.Rovers);
            Assert.AreEqual(1, plateau.Rovers.Count);
        }
    }
}