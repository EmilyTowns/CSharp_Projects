using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Math   //Creates a new public class
    {
        public int math(int number1)   //A method where number1 is the input
        {
            number1 = number1 * 10;   //Multiples number1 by 10
            return number1;   //Returns the resulting value
        }

        public int math(decimal number2)   //Overloaded method that uses a decimal input
        {
            number2 = number2 / 2;   //Divides the deciaml input by 2
            int number3 = Convert.ToInt32(number2);   //Converts the decimal result to an integer
            return number3;   //Returns the result
        }

        public int math(string words)   //Overloaded method that uses a string input
        {
            int number5 = Convert.ToInt32(words);   //Converts the string to an integer
            number5 = number5 + 100;   //Adds 100 to the resultant integer
            return number5;   //Returns the result
        }
    }
}
