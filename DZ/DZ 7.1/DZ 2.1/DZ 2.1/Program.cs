using System;

namespace DZ_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string? s = Console.ReadLine();
            string? s1 = Console.ReadLine();

            if (s != null && s1 != null)
            {
                int count = SubstringCounter.CountOccurrences(s, s1);
                Console.WriteLine(count);
            }
        }
    }
}

