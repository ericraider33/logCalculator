using System;
using Calculator.Methods;

namespace Calculator
{
    /**
     * NOTES:
     * http://www.ams.org/journals/mcom/1972-26-118/S0025-5718-1972-0307438-2/home.html
     * http://math.stackexchange.com/questions/75074/an-alternative-way-to-calculate-logx
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            ILogCalculator cal = new Eschenbach();
            Console.WriteLine(cal.calculate(2, 1));
            Console.WriteLine(cal.calculate(2, 2));
            Console.WriteLine(cal.calculate(2, 3));
            Console.WriteLine(cal.calculate(2, 4));
            Console.WriteLine(cal.calculate(2, 5));
            Console.WriteLine(cal.calculate(2, 6));
            Console.WriteLine(cal.calculate(2, 7));
            Console.WriteLine(cal.calculate(2, 8));
            Console.WriteLine(cal.calculate(2, 9));
           
            Console.ReadLine();
        }
    }
}
