using System;
using System.Collections.Generic;
using NUnit.Framework;
using DZ_1_1;

namespace DZ_1_1.Tests
{
    [TestFixture]
    public class PrimeNumberCalculatorTests
    {
        [Test]
        public void GetPrimeNumbers_ReturnsPrimesUpTo10()
        {
            var calculator = new PrimeNumberCalculator();
            int n = 10;

            var result = calculator.GetPrimeNumbers(n);

            var expected = new List<int> { 2, 3, 5, 7 };
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetPrimeNumbers_ReturnsEmptyListFor2()
        {
            var calculator = new PrimeNumberCalculator();
            int n = 2;

            var result = calculator.GetPrimeNumbers(n);

            Assert.IsEmpty(result);
        }

        [Test]
        public void GetPrimeNumbers_ReturnsPrimesUpTo30()
        {
            var calculator = new PrimeNumberCalculator();
            int n = 30;

            var result = calculator.GetPrimeNumbers(n);

            var expected = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            Assert.AreEqual(expected, result);
        }
    }
}