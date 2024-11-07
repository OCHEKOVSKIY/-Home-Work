using DZ_1;

namespace DZ_1._1_Test
{
    [TestFixture]
    public class PrimeNumbersTests
    {
        [Test]
        public void TestPrimesUpTo10()
        {
            string expectedOutput = "2\n3\n5\n7\n";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                RunPrimeNumberCode(10);
                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }

        [Test]
        public void TestPrimesUpTo5()
        {
            string expectedOutput = "2\n3\n";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                RunPrimeNumberCode(5);
                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }

        private void RunPrimeNumberCode(int n)
        {
            for (int i = 2; i < n; i++)
            {
                bool prav = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        prav = false;
                        break;
                    }
                }
                if (prav)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}