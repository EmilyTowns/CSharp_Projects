using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class Program
    {
        public static int in3 { get; private set; }   //Set integer in3 as being availble pubicly and set privately

        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number between 1-100:");   //Write to console asking for first number
            int in1 = Convert.ToInt32(Console.ReadLine());   //Sets user input as int1
            
            Console.WriteLine("You can now enter a second whole number between 1-100. If you do not want to enter another number, press enter instead.");   //Asks user for second input, to to hit enter if they dont want to enter a number
            string in2 = Console.ReadLine();   //Sets user input as a string
            
            if (!string.IsNullOrEmpty(in2))   //If the string stored to in2 is not null or empty - if the user entered a second number, convert the string to in int and store in in3
            {
                in3 = Convert.ToInt32(in2);
            }
            else   //If user did not enter a second number, assigns as in3 as null 
            {
                in3.Equals(null);
            }

            var math = new Math();   //Instantiates Math class
            var a = math.math(in1, in3);   //Assigns result of method to a
            Console.WriteLine("{0} plus {1} plus 20 equals {2}.", in1, in3, a);   //Writes result to console
            Console.ReadLine();   //Keeps console open
                     
        }
    }
}
