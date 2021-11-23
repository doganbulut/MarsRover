using MarsRover.App.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test.Expressions
{
    [TestClass()]
    public class MotionExpressionTests
    {
        [TestMethod()]
        public void ValidateTest()
        {

            // Arrange
            var validator = new Validator();

            // Act
            var success = validator.Motion.Validate("LMLMLMLMM");

            // Assert
            Assert.IsTrue(success);
        }

        [TestMethod()]
        public void ValidateFailTest()
        {

            // Arrange
            var validator = new Validator();

            // Act
            var success = validator.Motion.Validate("LMLMXXXLMLMM");

            // Assert
            Assert.IsFalse(success);
        }
    }
}