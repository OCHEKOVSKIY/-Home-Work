using System;
using System.Numerics;

namespace FactorialFibonacci
{
    public class Calculations
    {
        public static BigInteger FactorialIterative(int n)
        {
            if (n < 0) throw new ArgumentException("Factorial is not defined for negative numbers.");
            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }

        public static BigInteger FactorialRecursive(int n)
        {
            if (n < 0) throw new ArgumentException("Factorial is not defined for negative numbers.");
            if (n == 0 || n == 1) return 1;
            return n * FactorialRecursive(n - 1);
        }

        public static BigInteger FibonacciIterative(int n)
        {
            if (n < 0) throw new ArgumentException("Fibonacci is not defined for negative numbers.");
            if (n == 0) return 0;
            if (n == 1) return 1;

            BigInteger a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                BigInteger temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }

        public static BigInteger FibonacciRecursive(int n)
        {
            if (n < 0) throw new ArgumentException("Fibonacci is not defined for negative numbers.");
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        public static int FindThreshold(Func<int, BigInteger> recursiveFunc, Func<int, BigInteger> iterativeFunc)
        {
            const int threshold = 30;
            for (int n = 1; ; n++)
            {
                var recursiveTime = MeasureTime(() => recursiveFunc(n));
                var iterativeTime = MeasureTime(() => iterativeFunc(n));

                if (recursiveTime > iterativeTime * threshold)
                    return n;
            }
        }

        private static long MeasureTime(Action action)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            action();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Вычислить факториал");
            Console.WriteLine("2 - Вычислить число Фибоначчи");
            Console.WriteLine("3 - Найти порог скорости для рекурсивного и итеративного метода");
            Console.Write("Ваш выбор: ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 3))
            {
                Console.WriteLine("Некорректный выбор. Введите 1, 2 или 3.");
                Console.Write("Ваш выбор: ");
            }

            if (choice == 3)
            {
                Console.WriteLine("Выберите метод для анализа:");
                Console.WriteLine("1 - Факториал");
                Console.WriteLine("2 - Фибоначчи");
                Console.Write("Ваш выбор: ");

                int methodChoice;
                while (!int.TryParse(Console.ReadLine(), out methodChoice) || (methodChoice != 1 && methodChoice != 2))
                {
                    Console.WriteLine("Некорректный выбор. Введите 1 или 2.");
                    Console.Write("Ваш выбор: ");
                }

                int thresholdIndex = methodChoice == 1
                    ? Calculations.FindThreshold(Calculations.FactorialRecursive, Calculations.FactorialIterative)
                    : Calculations.FindThreshold(Calculations.FibonacciRecursive, Calculations.FibonacciIterative);

                Console.WriteLine($"Рекурсивный метод стал значительно медленнее на числе {thresholdIndex}.");
                return;
            }

            Console.Write("Введите число (целое неотрицательное): ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Некорректный ввод. Введите неотрицательное целое число.");
                Console.Write("Введите число: ");
            }

            Console.WriteLine("Выберите метод вычисления:");
            Console.WriteLine("1 - Рекурсивный");
            Console.WriteLine("2 - Итеративный");
            Console.Write("Ваш выбор: ");

            int method;
            while (!int.TryParse(Console.ReadLine(), out method) || (method != 1 && method != 2))
            {
                Console.WriteLine("Некорректный выбор. Введите 1 или 2.");
                Console.Write("Ваш выбор: ");
            }

            try
            {
                BigInteger result = 0;
                if (choice == 1)
                {
                    result = method == 1
                        ? Calculations.FactorialRecursive(n)
                        : Calculations.FactorialIterative(n);
                    Console.WriteLine($"Факториал числа {n} равен {result}");
                }
                else
                {
                    result = method == 1
                        ? Calculations.FibonacciRecursive(n)
                        : Calculations.FibonacciIterative(n);
                    Console.WriteLine($"Число Фибоначчи для {n} равно {result}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}