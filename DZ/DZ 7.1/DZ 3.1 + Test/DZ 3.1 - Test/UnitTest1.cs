using BinaryAddition;
namespace BinaryAddition.Tests
{
    public class BinaryAdditionTests
    {
        [Test]
        public void TestPositiveNumbers()
        {
            int num1 = 3;
            int num2 = 5;
            int expectedSum = 8;

            string binSum = Convert.ToString(num1 + num2, 2).TrimStart('0');
            int actualSum = num1 + num2;

            Assert.AreEqual("1000", binSum);
            Assert.AreEqual(expectedSum, actualSum);
        }

        [Test]
        public void TestNegativeNumbers()
        {
            int num1 = -3;
            int num2 = -5;
            int expectedSum = -8;

            string binSum = Convert.ToString(num1 + num2, 2).TrimStart('0');
            binSum = binSum == string.Empty ? "0" : binSum;
            int actualSum = num1 + num2;

            Assert.AreEqual("11111111111111111111111111111000", binSum);
            Assert.AreEqual(expectedSum, actualSum);
        }

        [Test]
        public void TestPositiveAndNegativeNumbers()
        {
            int num1 = 5;
            int num2 = -3;
            int expectedSum = 2;

            string binSum = Convert.ToString(num1 + num2, 2).TrimStart('0');
            int actualSum = num1 + num2;

            Assert.AreEqual("10", binSum);
            Assert.AreEqual(expectedSum, actualSum);
        }

        [Test]
        public void TestDifferentBinaryLengths()
        {
            int num1 = 1;
            int num2 = 1024;
            int expectedSum = 1025;

            string binSum = Convert.ToString(num1 + num2, 2).TrimStart('0');
            int actualSum = num1 + num2;

            Assert.AreEqual("10000000001", binSum);
            Assert.AreEqual(expectedSum, actualSum);
        }

        [Test]
        public void TestZeroSum()
        {
            int num1 = 0;
            int num2 = 0;
            int expectedSum = 0;

            string binSum = Convert.ToString(num1 + num2, 2).TrimStart('0');
            binSum = binSum == string.Empty ? "0" : binSum;
            int actualSum = num1 + num2;

            Assert.AreEqual("0", binSum);
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}