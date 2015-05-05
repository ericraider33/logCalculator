using Calculator.Methods;
using Calculator.Utils;

namespace CalculatorTest
{
    public class AttemptsFinder
    {
        public int Start { get; set; }
        public int Exhausted { get; set; }
        public decimal X { get; set; }
        public decimal AcceptableMin { get; set; }
        public decimal AcceptableMax { get; set; }

        public AttemptsFinder()
        {
            Start = 1;
            Exhausted = 1000;
            X = 2m;
            AcceptableMax = Constants.LN_2_MAX;
            AcceptableMin = Constants.LN_2_MIN;
        }

        public int testCalculator(ILogCalculator calculator)
        {
            for (int attempts = Start; attempts <= Exhausted; attempts++)
            {
                decimal result = calculator.calculate(X, attempts);
                if (result > AcceptableMin && result < AcceptableMax)
                    return attempts;
            }

            return -1;
        }
    }
}
