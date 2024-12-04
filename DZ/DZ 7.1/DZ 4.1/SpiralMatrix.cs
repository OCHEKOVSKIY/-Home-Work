namespace DZ_4_1
{
    public class SpiralMatrix
    {
        public static int[,] GenerateMatrix(int N)
        {
            int[,] array = new int[N, N];
            for (int i = 0, value = 1; i < N; i++)
                for (int j = 0; j < N; j++)
                    array[i, j] = value++;
            return array;
        }

        public static void PrintMatrix(int[,] array)
        {
            int N = array.GetLength(0);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(array[i, j].ToString().PadLeft(3) + " ");
                Console.WriteLine();
            }
        }

        public static void PrintSpiral(int[,] array)
        {
            int N = array.GetLength(0);
            int x = N / 2, y = N / 2;

            Console.Write(array[x, y] + " ");
            int step = 1;

            while (step < N)
            {
                for (int i = 0; i < step; i++) Console.Write(array[x, ++y] + " ");
                for (int i = 0; i < step; i++) Console.Write(array[++x, y] + " ");
                step++;

                for (int i = 0; i < step; i++) Console.Write(array[x, --y] + " ");
                for (int i = 0; i < step; i++) Console.Write(array[--x, y] + " ");
                step++;
            }

            for (int i = 0; i < step - 1; i++) Console.Write(array[x, ++y] + " ");
        }
    }
}
