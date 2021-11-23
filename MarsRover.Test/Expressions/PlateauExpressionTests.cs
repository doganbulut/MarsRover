using MarsRover.App.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test.Expressions
{
    [TestClass()]
    public class PlateauExpressionTests
    {
        [TestMethod()]
        public void ValidateTest()
        {

            // Arrange
            var validator = new Validator();

            // Act
            var success = validator.Plateau.Validate("5 5");

            // Assert
            Assert.IsTrue(success);
        }

        [TestMethod()]
        public void ValidateFailTest()
        {

            // Arrange
            var validator = new Validator();

            // Act
            var success = validator.Motion.Validate("E E");

            // Assert
            Assert.IsFalse(success);
        }
    }
}