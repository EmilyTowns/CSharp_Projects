using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 9;
            decimal number2 = 904556;
            string words = "55";

            var math = new Math();
            var a = math.math(number1);
            Console.WriteLine("{0} multiplied by 10 equals {1}.", number1, a);

            var math1 = new Math();
            var b = math1.math(number2);
            Console.WriteLine("{0} divided by 2 equals {1}.", number2, b);

            var math2 = new Math();
            var c = math2.math(words);
            Console.WriteLine("{0} plus 100 equals {1}.", words, c);

            Console.ReadLine();   //Keeps the console open
        }
    }
}
