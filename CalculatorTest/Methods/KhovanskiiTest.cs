using Calculator.Methods;
using NUnit.Framework;

namespace CalculatorTest.Methods
{
    [TestFixture]
    public class KhovanskiiTest
    {
        AttemptsFinder finder = new AttemptsFinder();
        Khovanskii calculator = new Khovanskii();

        [Test]
        public void testAttemptsLn2()
        {
            int attempts = finder.testCalculator(calculator);
            Assert.AreEqual(12, attempts);
        }
    }
}
