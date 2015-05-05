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
            Console.WriteLine(cal.calculate(200m, 100000));
//            Console.WriteLine(cal.calculate(0.5m, 1));
//            Console.WriteLine(cal.calculate(0.5m, 2));
//            Console.WriteLine(cal.calculate(0.5m, 3));
//            Console.WriteLine(cal.calculate(0.5m, 4));
//            Console.WriteLine(cal.calculate(0.5m, 5));
//            Console.WriteLine(cal.calculate(0.5m, 6));
//            Console.WriteLine(cal.calculate(0.5m, 7));
//            Console.WriteLine(cal.calculate(0.5m, 8));
//            Console.WriteLine(cal.calculate(0.5m, 9));
           
            Console.ReadLine();
        }
    }
}
