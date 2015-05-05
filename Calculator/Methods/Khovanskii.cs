using System;

namespace Calculator.Methods
{
    public class Khovanskii
    {
        public decimal calculate(decimal x, int attempts)
        {
            if (x > 3.14m || x < -3.14m)
                throw new ArgumentException("Range can't be computed");

            decimal z = x - 1;
            decimal zSquared = z * z;
            decimal zPlus2 = z + 2;
            decimal kPart = 0m;
            for (int k = attempts; k >= 1; k--)
            {
                decimal termSquared = k * k;
                decimal kConstant = 1 + 2 * k;
                kPart = termSquared * zSquared / (kConstant * zPlus2 - kPart);
            }

            decimal result = 2 * z / (zPlus2 - kPart);
            return result;
        }

    }
}
