using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's demonstrate dividion with a list. First, here is our original list of numbers:");   //Writes to console

            List<int> numList = new List<int>()   //Creates a new list and adds integers to list
                {
                    100, 90, 80, 70, 60, 50, 40, 30, 20, 10
                };

            foreach (int num in numList)   //A foreach loop to write each number in the list to the console
            {
                Console.WriteLine(num);
            }

            try   //Starts a try catch block for exception handling
            {
                Console.WriteLine("Now, enter a whole number from 1-10:");   //Writes to console prompting user entry
                int input = Convert.ToInt32(Console.ReadLine());   //Converts user entry to integer and writes to variable input

                Console.WriteLine("Now, let's divide each by " + input + " and round to the nearest whole number:");   //Writes to console

                foreach (int num in numList)   //Foreach loop to run through list of integers and divide each by user-entered integer
                {
                    Console.WriteLine(num + " divided by " + input + " equals " + (num / input));
                }
            }

            catch (DivideByZeroException ex)   //Catch block to display error message if user enters a zero
            {
                Console.WriteLine("Error. Can't divide by zero.");
            }

            catch (FormatException ex)   //Catch block to display error message is user enters a format other than an integer
            {
                Console.WriteLine("Error. Please enter a whole number between 1-9.");
            }

            catch (Exception ex)   //Catch block to display generic error message for any other exceptions
            {
                Console.WriteLine(ex.Message);
            }

            finally   //Finally block to keep console open for user to see error messages
            {
                Console.ReadLine();
            }           
        }
    }
}
