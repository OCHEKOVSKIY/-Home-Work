using System;

namespace BinaryAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int num2 = int.Parse(Console.ReadLine());

            string bin1 = Convert.ToString(num1, 2).TrimStart('0');
            string bin2 = Convert.ToString(num2, 2).TrimStart('0');

            bin1 = bin1 == string.Empty ? "0" : bin1;
            bin2 = bin2 == string.Empty ? "0" : bin2;

            Console.WriteLine($"Число 1 в двоичном виде: {bin1}");
            Console.WriteLine($"Число 2 в двоичном виде: {bin2}");

            int sum = num1 + num2;

            string binSum = Convert.ToString(sum, 2).TrimStart('0');
            binSum = binSum == string.Empty ? "0" : binSum;

            Console.WriteLine($"Сумма в двоичном виде: {binSum}");
            Console.WriteLine($"Сумма в десятичном виде: {sum}");
        }
    }
}