using System;

namespace Calculator.Methods
{
    public class MaclaurinB : ILogCalculator
    {
        public decimal calculate(decimal y, int attempts)
        {
            decimal x = (y - 1) / (y + 1);
            if (x >= 1 || x <= -1)
                throw new ArgumentException("Value is outside of computation range");
            
            decimal sum = 0m;
            decimal xPartK = x;
            for (int k = 0; k <= attempts; k++)
            {
                sum += xPartK / (2*k + 1);
                xPartK = xPartK * x * x;
            }

            return sum*2;
        }
    }
}
