using Calculator.Methods;
using NUnit.Framework;

namespace CalculatorTest.Methods
{
    [TestFixture]
    public class EschenbachTest
    {
        AttemptsFinder finder = new AttemptsFinder();
        Eschenbach calculator = new Eschenbach();

        [Test]
        public void testAttemptsLn2()
        {
            int attempts = finder.testCalculator(calculator);
            Assert.AreEqual(59, attempts);
        }
    }
}
