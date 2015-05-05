namespace Calculator.Methods
{
    public class Eschenbach : ILogCalculator
    {
        public decimal calculate(decimal x, int attempts)
        {
            decimal sum = 0m;
            decimal xPart = (x - 1) / x;
            decimal xPartK = 1m;
            for (int k = 0; k <= attempts; k++)
            {
                xPartK = xPartK * xPart;
                sum += xPartK / (k + 1);
            }

            return sum;
        }
    }
}
