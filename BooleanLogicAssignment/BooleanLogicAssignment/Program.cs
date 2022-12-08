using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Qualification");   //Write title to console

            Console.WriteLine("What is your age? Enter a number.");   //Write to console to prompt user entry of a number
            int age = Convert.ToInt32(Console.ReadLine());   //Assigns response converted to an integer

            Console.WriteLine("Have you ever had a DUI? Answer \"true\" or \"false\".");   //Write to console to prompt user entry of true or false
            bool dui = Convert.ToBoolean(Console.ReadLine());   //Assigns response converted to boolean

            Console.WriteLine("How many speeding tickets do you have? Enter a number.");   //Write to console to prompt user entry of a number
            int tickets = Convert.ToInt32(Console.ReadLine());   //Assigns response converted to integer

            Console.WriteLine("Do you qualify?");   //Writes to console
            bool qualify = (age >= 15 && dui == false && tickets <= 3);   //Checks is age is at or above 15 AND there are no duis AND there are 3 or less tickets 
            Console.WriteLine(qualify);   //Writes boolean response to console
            Console.ReadLine(); 

        }
    }
}
