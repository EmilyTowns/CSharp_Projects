using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. How old will you be turning this year?");   //Writes to console prompting for user intput 

            try   //Starts try/catch block
            {
                int userAge = Convert.ToInt32(Console.ReadLine());   //Saves user input as an integer
                if (userAge <= 0) throw new FormatException();   //Throws a format exception if the age entered by the user is 0 or less
                DateTime today = DateTime.Today;   //Gets the date today
                var age = today.Year - userAge;   //Takes away the user entered age from the current year
                Console.WriteLine("You were born in {0}.", age);   //Writes result of birth year to console
                Console.ReadLine();   //Keeps console open
            }
            catch (FormatException)   //Catch block for a format exception if it is thrown in the try block
            {
                Console.WriteLine("Your age cannot be zero or a negative number.");   //Tells user they cannot be 0 or a negative number
                Console.ReadLine();   //Keeps console open
            }
            catch (Exception)   //Catch block for general exceptions
            {
                Console.WriteLine("An error occured, please contact your administrator.");   //Error message if there are any other exceptions in try block
                Console.ReadLine();   //Keeps console open
            }         
        }
    }
}
