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

            // Создаём объект для выполнения вычислений
            var calculator = new DivisionCalculator();

            // Вызываем метод для выполнения вычислений
            calculator.Calculate(a, k);

            // Выводим результаты
            Console.WriteLine($"Целая часть {calculator.N}, остаток {calculator.A}");
        }
    }
}