using MarsRover.Entities;
using MarsRover.Enums;
using MarsRover.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test
{
    [TestClass()]
    public class NavigatorTests
    {

        [TestMethod()]
        public void TurnArroundLeftTest()
        {
            // Arrange
            var navigator = new Navigator(new Surface(5, 5), new Position(0, 0, CompassDirections.N));

            // Act
            navigator.TurnLeft();
            // Assert
            Assert.AreEqual("0 0 W", navigator.Position.ToString());

            // Act
            navigator.TurnLeft();
            // Assert
            Assert.AreEqual("0 0 S", navigator.Position.ToString());

            // Act
            navigator.TurnLeft();
            // Assert
            Assert.AreEqual("0 0 E", navigator.Position.ToString());

            // Act
            navigator.TurnLeft();
            // Assert
            Assert.AreEqual("0 0 N", navigator.Position.ToString());

        }

        [TestMethod()]
        public void TurnArroundRightTest()
        {
            // Arrange
            var navigator = new Navigator(new Surface(5, 5), new Position(0, 0, CompassDirections.N));

            // Act
            navigator.TurnRight();
            // Assert
            Assert.AreEqual("0 0 E", navigator.Position.ToString());

            // Act
            navigator.TurnRight();
            // Assert
            Assert.AreEqual("0 0 S", navigator.Position.ToString());

            // Act
            navigator.TurnRight();
            // Assert
            Assert.AreEqual("0 0 W", navigator.Position.ToString());

            // Act
            navigator.TurnRight();
            // Assert
            Assert.AreEqual("0 0 N", navigator.Position.ToString());
        }

        [TestMethod()]
        public void TryMovetoNorthTest()
        {
            // Arrange
            var navigator = new Navigator(new Surface(5, 5), new Position(0, 0, CompassDirections.N));

            // Act
            var success = navigator.TryMove();
            // Assert
            Assert.IsTrue(success);

            // Assert
            Assert.AreEqual("0 1 N", navigator.Position.ToString());

            navigator.TryMove();
            // Assert
            Assert.AreEqual("0 2 N", navigator.Position.ToString());

        }

        [TestMethod()]
        public void TryMovetoEastTest()
        {
            // Arrange
            var navigator = new Navigator(new Surface(5, 5), new Position(0, 0, CompassDirections.E));

            // Act
            var success = navigator.TryMove();
            // Assert
            Assert.IsTrue(success);

            // Assert
            Assert.AreEqual("1 0 E", navigator.Position.ToString());

            navigator.TryMove();
            // Assert
            Assert.AreEqual("2 0 E", navigator.Position.ToString());

        }

        [TestMethod()]
        public void TryOutOfLimitMovetoNorthFailTest()
        {
            // Arrange
            var navigator = new Navigator(new Surface(5, 5), new Position(0, 0, CompassDirections.N));

            // Act
            bool success = true;
            for (int i = 0; i < 10; i++)
                success = navigator.TryMove();
            // Assert
            Assert.IsFalse(success);
        }

        [TestMethod()]
        public void TryOutOfLimitMovetoEastFailTest()
        {
            // Arrange
            var navigator = new Navigator(new Surface(5, 5), new Position(0, 0, CompassDirections.E));

            // Act
            bool success = true;
            for (int i = 0; i < 10; i++)
                success = navigator.TryMove();
            // Assert
            Assert.IsFalse(success);
        }


        [TestMethod()]
        public void TryOutOfLimitMovetoWestFailTest()
        {
            // Arrange
            var navigator = new Navigator(new Surface(5, 5), new Position(0, 0, CompassDirections.W));

            // Act
            bool success = navigator.TryMove();
            // Assert
            Assert.IsFalse(success);
        }

        [TestMethod()]
        public void TryOutOfLimitMovetoSouthFailTest()
        {
            // Arrange
            var navigator = new Navigator(new Surface(5, 5), new Position(0, 0, CompassDirections.S));

            // Act
            bool success = navigator.TryMove();
            // Assert
            Assert.IsFalse(success);
        }


    }
}