using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите радиус окружности: ");
        int radius = Convert.ToInt32(Console.ReadLine());

        for (int y = -radius; y <= radius; y++)
        {
            for (int x = -radius; x <= radius; x++)
            {
                if (Math.Abs(x * x + y * y - radius * radius) < radius)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}