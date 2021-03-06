using MarsRover.App.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test.Expressions
{
    [TestClass()]
    public class PositionExpressionTests
    {
        [TestMethod()]
        public void ValidateTest()
        {

            // Arrange
            var validator = new Validator();

            // Act
            var success = validator.Position.Validate("1 2 N");

            // Assert
            Assert.IsTrue(success);
        }

        [TestMethod()]
        public void ValidateFailTest()
        {

            // Arrange
            var validator = new Validator();

            // Act
            var success = validator.Position.Validate("1 1 1");

            // Assert
            Assert.IsFalse(success);
        }
    }
}