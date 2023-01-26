using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public class Math   //Creates public class Math
    {
        public void math(int num1)   //Creates public void method, which means it will not have a return value
        {
            int num2 = num1 / 2;   //Takes input and performs math operation
            Console.WriteLine("{0} divided by 2 equals {1}.", num1, num2);   //Writes result to console, which will be result when method is called
        }

        public void math1(out int num2)   //Creates public void method with an out parameter
        {
            num2 = 60;   //Assigns value to output number, which will change the value which was passed to it
        }

        public void math1(out int num2, int num3)   //Creates an overloaded method with both an input and output parameter
        {
            num2 = num3 * 2;  //Uses input parameter to perform math equal to output parameter
        }
    }
}
