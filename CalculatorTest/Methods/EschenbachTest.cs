using Calculator.Methods;
using Calculator.Utils;
using NUnit.Framework;

namespace CalculatorTest.Methods
{
    [TestFixture]
    public class EschenbachTest
    {
        Eschenbach calculator = new Eschenbach();

        [Test]
        public void testAttemptsLn2()
        {
            AttemptsFinder finder = new AttemptsFinder();
            int attempts = finder.testCalculator(calculator);
            Assert.AreEqual(59, attempts);
        }

        [Test]
        public void testAttemptsLn0_5()
        {
            AttemptsFinder finder = new AttemptsFinder { X = 0.5m, AcceptableMin = Constants.LN_0_5_MIN, AcceptableMax = Constants.LN_0_5_MAX };
            int attempts = finder.testCalculator(calculator);
            Assert.AreEqual(-1, attempts);                          // never reaches range
        }

        [Test]
        public void testAttemptsLn200()
        {
            AttemptsFinder finder = new AttemptsFinder { X = 200m, AcceptableMin = Constants.LN_200_MIN, AcceptableMax = Constants.LN_200_MAX, Start = 8380, Exhausted = 8380 };
            int attempts = finder.testCalculator(calculator);
            Assert.AreEqual(8380, attempts);                          // never reaches range
        }
    }
}
