using Calculator.Methods;
using Calculator.Utils;
using NUnit.Framework;

namespace CalculatorTest.Methods
{
    [TestFixture]
    public class MaclaurinBTest
    {
        MaclaurinB calculator = new MaclaurinB();

        [Test]
        public void testAttemptsLn2()
        {
            AttemptsFinder finder = new AttemptsFinder();
            int attempts = finder.testCalculator(calculator);
            Assert.AreEqual(18, attempts);                          // never reaches range
        }

        [Test]
        public void testAttemptsLn0_5()
        {
            AttemptsFinder finder = new AttemptsFinder { X = 0.5m, AcceptableMin = Constants.LN_0_5_MIN, AcceptableMax = Constants.LN_0_5_MAX };
            int attempts = finder.testCalculator(calculator);
            Assert.AreEqual(18, attempts);                          
        }
    }

}
