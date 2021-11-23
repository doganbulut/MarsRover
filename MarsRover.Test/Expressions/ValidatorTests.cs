using MarsRover.App.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test.Expressions
{
    [TestClass()]
    public class ValidatorTests
    {
        [TestMethod()]
        public void ValidatorTest()
        {
            // Arrange
            var validator = new Validator();

            // Act


            // Assert
            Assert.IsNotNull(validator);
            Assert.IsNotNull(validator.Plateau);
            Assert.IsNotNull(validator.Motion);
            Assert.IsNotNull(validator.Position);
        }
    }
}