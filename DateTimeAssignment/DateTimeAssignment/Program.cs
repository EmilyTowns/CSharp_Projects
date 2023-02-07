using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeNow = DateTime.Now;   //Gets the current date and time and assigns to DateTime variable
            Console.WriteLine("This is the current date and time: {0}", timeNow);   //Writes to console

            Console.WriteLine("Please enter a whole number between 1-100:");   //Writes to console for user input
            int userInput = Convert.ToInt32(Console.ReadLine());   //Saves user input as an integer
            TimeSpan userTime = new TimeSpan(userInput, 0, 0);   //Creates a timespan variable using (hours, minutes, seconds), using the integer as the hours
            DateTime calculation = timeNow.Add(userTime);   //Adds the timespan from the user input to the current datetime

            Console.WriteLine("If you add {0} hours to the current time, the resulting date and time is: {1}", userInput, calculation);   //Writes the result to the console
            Console.ReadLine();   //Keeps the console open
        }
    }
}
