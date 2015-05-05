using System;

namespace Calculator.Methods
{
    public class MaclaurinA : ILogCalculator
    {
        public decimal calculate(decimal x, int attempts)
        {
            if (x > 2 || x <= 0)
                throw new ArgumentException("Value is outside of computation range");

            x = x - 1;
            decimal sum = 0m;
            decimal xPartK = 1m;
            for (int k = 0; k <= attempts; k++)
            {
                xPartK = xPartK * x;
                if (k % 2 == 0)
                    sum += xPartK / (k + 1);
                else
                    sum -= xPartK / (k + 1);
            }

            return sum;
        }
    }
}
