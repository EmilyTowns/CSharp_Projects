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
            int number1 = 9;   //Assigns values to the variables
            decimal number2 = 904556;
            string words = "55";

            var math = new Math();   //Instantiates the class
            var a = math.math(number1);   //Assigns the result of integer method to a variable
            Console.WriteLine("{0} multiplied by 10 equals {1}.", number1, a);   //Writes result to console

            var math1 = new Math();   //Instantiates the class again
            var b = math1.math(number2);   //Assigns the result of decimal method to a variable
            Console.WriteLine("{0} divided by 2 equals {1}.", number2, b);   //Writes result to console

            var math2 = new Math();   //Instantiates the class again
            var c = math2.math(words);   //Assigns the result of string method to a variable
            Console.WriteLine("{0} plus 100 equals {1}.", words, c);   //Writes result to console

            Console.ReadLine();   //Keeps the console open
        }
    }
}
