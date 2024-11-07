using System;

namespace DZ_1_2
{
    public class DivisionCalculator
    {
        public int N { get; private set; } 
        public int A { get; private set; } 

        public void Calculate(int a, int k)
        {

            if (k == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно.");
            }


            N = a / k;


            A = a - (N * k);


            if (A < 0)
            {

                A += Math.Abs(k);
                N -= 1;
            }


            if (a < 0 && k < 0)
            {
                N = Math.Abs(N);
            }
        }
    }
}
