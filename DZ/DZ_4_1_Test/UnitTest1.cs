using NUnit.Framework;
using DZ_4_1;

namespace DZ_4_1.Tests
{
    [TestFixture]
    public class SpiralMatrixTests
    {
        [Test]
        public void TestGenerateMatrix_5x5Matrix_CorrectlyFilled()
        {
            int N = 5;
            int[,] result = SpiralMatrix.GenerateMatrix(N);
            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(25, result[N - 1, N - 1]);
        }

        [Test]
        public void TestGenerateMatrix_3x3Matrix_CorrectlyFilled()
        {
            int N = 3;
            int[,] result = SpiralMatrix.GenerateMatrix(N);
            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(9, result[N - 1, N - 1]);
        }

        [Test]
        public void TestPrintSpiral_ValidInput_ReturnsCorrectSpiralOrder()
        {
            int N = 5;
            int[,] matrix = SpiralMatrix.GenerateMatrix(N);
            var sw = new System.IO.StringWriter();
            Console.SetOut(sw);
            SpiralMatrix.PrintSpiral(matrix);
            string output = sw.ToString();
            Assert.IsTrue(output.StartsWith("1"));
            Assert.IsTrue(output.Contains("25"));
        }
    }
}
