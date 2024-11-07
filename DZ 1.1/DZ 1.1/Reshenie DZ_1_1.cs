using System;
using System.Collections.Generic;

namespace DZ_1_1
{
    public class PrimeNumberCalculator
    {
        public List<int> GetPrimeNumbers(int n)
        {
            var primes = new List<int>();
            for (int i = 2; i < n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) primes.Add(i);
            }
            return primes;
        }
    }
}