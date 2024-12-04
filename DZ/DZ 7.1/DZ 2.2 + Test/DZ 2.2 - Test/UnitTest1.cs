using NUnit.Framework;
using System;
using System.Numerics;
using FactorialFibonacci;

namespace FactorialFibonacci.Tests

{
    [TestFixture]
    public class CalculationsTests
    {
        [Test]
        public void FactorialIterative_Test()
        {
            Assert.AreEqual((BigInteger)1, Calculations.FactorialIterative(0));
            Assert.AreEqual((BigInteger)1, Calculations.FactorialIterative(1));
            Assert.AreEqual((BigInteger)120, Calculations.FactorialIterative(5));
            Assert.AreEqual((BigInteger)3628800, Calculations.FactorialIterative(10));
        }

        [Test]
        public void FactorialRecursive_Test()
        {
            Assert.AreEqual((BigInteger)1, Calculations.FactorialRecursive(0));
            Assert.AreEqual((BigInteger)1, Calculations.FactorialRecursive(1));
            Assert.AreEqual((BigInteger)120, Calculations.FactorialRecursive(5));
            Assert.AreEqual((BigInteger)3628800, Calculations.FactorialRecursive(10));
        }

        [Test]
        public void FibonacciIterative_Test()
        {
            Assert.AreEqual((BigInteger)0, Calculations.FibonacciIterative(0));
            Assert.AreEqual((BigInteger)1, Calculations.FibonacciIterative(1));
            Assert.AreEqual((BigInteger)5, Calculations.FibonacciIterative(5));
            Assert.AreEqual((BigInteger)55, Calculations.FibonacciIterative(10));
        }

        [Test]
        public void FibonacciRecursive_Test()
        {
            Assert.AreEqual((BigInteger)0, Calculations.FibonacciRecursive(0));
            Assert.AreEqual((BigInteger)1, Calculations.FibonacciRecursive(1));
            Assert.AreEqual((BigInteger)5, Calculations.FibonacciRecursive(5));
            Assert.AreEqual((BigInteger)55, Calculations.FibonacciRecursive(10));
        }

        [Test]
        public void Factorial_Iterative_And_Recursive_Comparison()
        {
            for (int n = 0; n <= 15; n++) // Ограничим диапазон
            {
                Assert.AreEqual(
                    Calculations.FactorialIterative(n),
                    Calculations.FactorialRecursive(n),
                    $"Mismatch for Factorial({n})"
                );
            }
        }

        [Test]
        public void Fibonacci_Iterative_And_Recursive_Comparison()
        {
            for (int n = 0; n <= 20; n++) // Ограничим диапазон
            {
                Assert.AreEqual(
                    Calculations.FibonacciIterative(n),
                    Calculations.FibonacciRecursive(n),
                    $"Mismatch for Fibonacci({n})"
                );
            }
        }

        [Test]
        public void FindThreshold_Test_Factorial()
        {
            int threshold = Calculations.FindThreshold(
                Calculations.FactorialRecursive,
                Calculations.FactorialIterative
            );
            Assert.Greater(threshold, 0, "Threshold should be a positive number.");
        }

        [Test]
        public void FindThreshold_Test_Fibonacci()
        {
            int threshold = Calculations.FindThreshold(
                Calculations.FibonacciRecursive,
                Calculations.FibonacciIterative
            );
            Assert.Greater(threshold, 0, "Threshold should be a positive number.");
        }

        [Test]
        public void Factorial_Throws_Exception_For_Negative_Input()
        {
            Assert.Throws<ArgumentException>(() => Calculations.FactorialIterative(-1));
            Assert.Throws<ArgumentException>(() => Calculations.FactorialRecursive(-1));
        }

        [Test]
        public void Fibonacci_Throws_Exception_For_Negative_Input()
        {
            Assert.Throws<ArgumentException>(() => Calculations.FibonacciIterative(-1));
            Assert.Throws<ArgumentException>(() => Calculations.FibonacciRecursive(-1));
        }
    }
}