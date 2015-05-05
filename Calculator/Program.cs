using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Methods;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Khovanskii cal = new Khovanskii();
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
