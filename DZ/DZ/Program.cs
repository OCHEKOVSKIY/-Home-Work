using System;

namespace DZ_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] array = SpiralMatrix.GenerateMatrix(N);

            SpiralMatrix.PrintMatrix(array);

            Console.WriteLine();
            SpiralMatrix.PrintSpiral(array);
        }
    }
}
