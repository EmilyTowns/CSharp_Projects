using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 9;   //Assigns 9 to the integer number
            int multiple = Math.math(number);   //Creates a new integer and calls the function, passing it the integer number
            Console.WriteLine("{0} multiplied by 10 equals {1}.", number, multiple);   //Writes the results to the console

            decimal number4 = 904556;   //Assigns 904556 to a decimal 
            int convert = Math.math(number4);   //Creates a new integer and calls the function, passing it the decimal number4
            Console.WriteLine("{0} divided by 2 equals {1}.", number4, convert);   //Writes the results to the console

            string words = "55";   //Assigns "55" to a string
            int fromString = Math.math(words);   //Creates a new integer and calls the function, passing it the string value
            Console.WriteLine("{0} plus 100 equals {1}.", words, fromString);   //Writes the results to the console
            Console.ReadLine();   //Keeps the console open
        }
    }
}
