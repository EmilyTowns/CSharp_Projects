using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try   //Starts try catch block for exception handling
            {
                Console.WriteLine("Please enter the current day of the week:");   //Writes to console asking for user entry
                string day = Console.ReadLine();   //Assigns user input as string day
                Enum.Parse(typeof(DaysOfTheWeek), day);   //Parses day to be usable as the same data type as DaysOfTheWeek enum, to compare to enum and ensure it is in the list
                Console.WriteLine("You input the current day of the week as: {0}", day);   //Writes user entry to console
            }
            catch (Exception)   //Catch block that will run if there is an exception - if the user input a value not on the enum list
            {
                Console.WriteLine("Please enter an actual day of the week.");   //Writes to console informing of error
            }
            finally
            {
                Console.ReadLine();   //Ensures console stays open whether catch block runs or not
            }
        }

        public enum DaysOfTheWeek   //Declares public enum listing the days of the week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
