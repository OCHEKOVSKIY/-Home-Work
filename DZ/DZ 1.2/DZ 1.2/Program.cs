using System;
namespace DZ_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число k:");
            int k = Convert.ToInt32(Console.ReadLine());


            var calculator = new DivisionCalculator();


            calculator.Calculate(a, k);


            Console.WriteLine($"Целая часть {calculator.N}, остаток {calculator.A}");
        }
    }
}