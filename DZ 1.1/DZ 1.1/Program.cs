using System;

namespace DZ_1_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var calculator = new PrimeNumberCalculator();
            var primes = calculator.GetPrimeNumbers(n);

            foreach (var prime in primes)
            {
                Console.WriteLine(prime);
            }
        }
    }
}