using Calculator;
using NUnit.Framework;
using Moq;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arrange
            var sut = new Mock<ICalculation>();
            sut.Setup(s => s.Verifiable).Returns(true);

            // Act

            // Assert
            Assert.IsTrue(sut.Object.Verifiable);
        }
    }
}