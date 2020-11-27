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

        [Test]
        public void PresenterOutputTest()
        {
            // Arrange
            var sut = new Mock<IPresenter>();
            sut.Setup(s => s.Person).Returns("Sir");
            sut.Setup(s => s.GetAnswer(It.IsAny<ICalculation>()))
                .Returns($"Dear {sut.Object.Person}, here is your answer - 12.");
            var calculation = new Mock<ICalculation>();

            // Act
            var output = sut.Object.GetAnswer(calculation.Object);

            // Assert
            Assert.AreEqual("Dear Sir, here is your answer - 12.", output);
        }

        [Test]
        public void EmbeddedConstructorCallTest()
        {
            // Arrange

            // Act
            var sut = new Point3D();

            // Assert
            Assert.AreEqual(0.0, sut.X);
            Assert.AreEqual(0.0, sut.Y);
            Assert.AreEqual(0.0, sut.Z);
        }
    }
}