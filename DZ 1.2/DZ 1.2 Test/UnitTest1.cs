using NUnit.Framework;
using DZ_1_2;  // Пространство имён для класса DivisionCalculator

namespace DZ_1_2.Tests
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        private DivisionCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new DivisionCalculator();
        }

        [Test]
        public void TestPositiveNumbers()
        {
            _calculator.Calculate(78, 33);
            Assert.AreEqual(2, _calculator.N);
            Assert.AreEqual(12, _calculator.A);
        }

        [Test]
        public void TestNegativeNumeratorPositiveDenominator()
        {
            _calculator.Calculate(-78, 33);
            Assert.AreEqual(-3, _calculator.N);
            Assert.AreEqual(21, _calculator.A);
        }

        [Test]
        public void TestNegativeNumeratorNegativeDenominator()
        {
            _calculator.Calculate(-9, -13);
            Assert.AreEqual(1, _calculator.N);
            Assert.AreEqual(4, _calculator.A);
        }

        [Test]
        public void TestPositiveNumeratorNegativeDenominator()
        {
            _calculator.Calculate(9, -90);
            Assert.AreEqual(0, _calculator.N);
            Assert.AreEqual(9, _calculator.A);
        }

        [Test]
        public void TestDividingByOne()
        {
            _calculator.Calculate(10, 1);
            Assert.AreEqual(10, _calculator.N);
            Assert.AreEqual(0, _calculator.A);
        }

        [Test]
        public void TestDividingByZero()
        {
            var exception = Assert.Throws<DivideByZeroException>(() => _calculator.Calculate(10, 0));
            Assert.That(exception.Message, Is.EqualTo("Деление на ноль невозможно."));
        }
    }
}
