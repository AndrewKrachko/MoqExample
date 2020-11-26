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
        public void CalculationVerificationTest()
        {
            // Arrange
            var sut = new Mock<ICalculation>();
            sut.Setup(s => s.Verifiable).Returns(true);

            // Act

            // Assert
            Assert.IsTrue(sut.Object.Verifiable);
        }

        [Test]
        public void CalculationEvaluationTest()
        {
            // Arrange
            var sut = new Mock<ICalculation>();
            sut.Setup(s => s.Evaluate()).Returns(50);

            // Act

            // Assert
            Assert.AreEqual(50, sut.Object.Evaluate());
        }
    }
}