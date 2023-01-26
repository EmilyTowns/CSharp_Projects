using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number less than 500:");   //Writes to console asking for user input
            int number1 = Convert.ToInt32(Console.ReadLine());   //Converts user input to integer number1
            var math = new Math();   //Instantiates Math class
            math.math(number1);   //Calls the method, which will output the Console.WriteLine contained within the method

            int number2 = 42;   //Creates integer and assigns value
            Console.WriteLine();   //Creates a blank line to divide sections for clarity
            Console.WriteLine("This is an example of using an out parameter. The integer number2 is currently equal to: " + number2);   //Writes current value of number2 to console
            math.math1(out number2);   //Calls method with out parameter (class was already instantiated in previous section)
            Console.WriteLine("After calling our method with an out parameter, number2 is: " + number2);   //number2 has now been changed by method and output

            int number3 = 6;   //Creates integer and assigns value
            int number4;   //Creates another integer
            math.math1(out number4, number3);   //Uses same method as last section, but uses overloaded version which takes in a value and also outputs a value
            Console.WriteLine();   //Creates a blank line to divide sections for clarity
            Console.WriteLine("This is an example of using method overloading:");
            Console.WriteLine("If I input {0} to my overloaded method, I get {1} as an out parameter back.", number3, number4);   //Displays input and output values to console

            int number5 = 16;   //Creates integer and assigns value
            int number6 = AClass.thisIsStatic(number5);   //Creates integer and calls method - because it is a static class/method, it cannot be instantiated
            Console.WriteLine();   //Creates a blank line to divide sections for clarity
            Console.WriteLine("This is an example of using a static class, which you cannot instantiate:");  
            Console.WriteLine("{0} plus 22 equals {1}.", number5, number6);   //Writes result to console

            Console.ReadLine();   //Keeps console open
        }
    }
}
