using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Math   //Creates a new public class
    {
        public static int math(int number1)   //Creates a new method where an integer can be passed in 
        {
            number1 = number1 * 10;   //Takes the input integer and multiples by 10
            return number1;   //Returns the result
        }

        public static int math(decimal number2)   //Overloads the method by adding the option to pass in a decimal number
        {
            number2 = number2 / 2;   //Divides the number by 2
            int number3 = Convert.ToInt32(number2);   //Takes the decimal result and converts it to an integer
            return number3;   //Returns the integer result
        }

        public static int math(string words)   //Overloads the method again by adding the option to pass in a string value
        {
            int number5 = Convert.ToInt32(words);   //Converts the string value to an integer
            number5 = number5 + 100;   //Add 100 to the converted intger
            return number5;   //Returns the result
        }
    }
}
