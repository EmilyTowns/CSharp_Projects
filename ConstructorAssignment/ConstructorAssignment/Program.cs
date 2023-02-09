using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string pageName = "User Entry System";   //App title is assigned as a constant because it will not change
            Console.WriteLine(pageName);   //Writes page name to console

            Console.WriteLine("Enter new user first name:");   //Prompts for entry of new user first name
            var firstName = Console.ReadLine();   //Assigns user input to a variable, which will be determined to be string input
            Console.WriteLine("Enter new user last name:");   //Prompts for entry of last name
            var lastName = Console.ReadLine();   //Assins this input to another variable which will also automatically be assigned as a string

            User user = new User(firstName, lastName);   //Calls User and inputs the first and last name variables

            Console.ReadLine();   //Keeps the console open
        }
    }
}
