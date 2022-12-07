using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 90;
            int num2 = 45;

            int sum = num1 + num2;
            Console.WriteLine(num1 + " plus " + num2 + " equals " + sum + ".");

            int difference = num1 - num2;
            Console.WriteLine(num1 + " minus " + num2 + " equals " + difference + ".");

            int product = num1 * num2;
            Console.WriteLine(num1 + " multiplied by " + num2 + " equals " + product + ".");

            int quotient = num1 / num2;
            Console.WriteLine(num1 + " divided by " + num2 + " equals " + quotient + ".");

            string word = "COVID-";
            int number = 19;
            Console.WriteLine(word + number);
            Console.Read();

        }
    }
}
