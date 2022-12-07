using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number betweeen 0 and 10: ");   //Writes line to console to prompt user entry
            int num1 = Convert.ToInt32(Console.ReadLine());   //Assigns user entry, converting it to an integer
            int answer1 = num1 * 50;   //Assigns the result of the user-entered number times 50
            Console.WriteLine(num1 + " multiplied by fifty equals: " + answer1);   //Writes the result to the console

            Console.WriteLine("Pick another number betweeen 0 and 10: ");   //Writes line to console to prompt another user entry
            int num2 = Convert.ToInt32(Console.ReadLine());   //Assigns user entry, converting it to an integer
            int answer2 = num2 + 25;   //Assigns the result of the user-entered number plus 25
            Console.WriteLine(num2 + " plus twenty-five equals: " + answer2);   //Writes the result to the console

            Console.WriteLine("Pick a number betweeen 50 and 100: ");   //Writes line to console to prompt another user entry
            double num3 = Convert.ToDouble(Console.ReadLine());   //Assigns user entry, converting it to double
            double answer3 = num3 / 12.5;   //Assigns the result of the user-entered number divided by 12.5
            Console.WriteLine(num3 + " divided by twelve and a half equals: " + answer3);   //Writes the result to the console

            Console.WriteLine("Pick another number betweeen 50 and 100: ");   //Writes line to console to prompt another user entry
            int num4 = Convert.ToInt32(Console.ReadLine());   //Assigns user entry, converting it to double
            int answer4 = num4 / 7;   //Assigns the result of the user-entered number divided by 7
            int answer5 = num4 % 7;   //Assigns the result of the remainder of the user-entered number when divided by 7
            Console.WriteLine(num4 + " divided by seven equals " + answer4 + " with a remainder of " + answer5);   //Writes the results to the console
            Console.ReadLine();

        }
    }
}
