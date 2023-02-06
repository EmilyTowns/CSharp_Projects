using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;   //Contains the file class

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number between 1 and 100:");   //Writes line to console asking for user input
            string number = Console.ReadLine();   //Saves user input as a string value

            File.WriteAllText(@"C:\Users\emily\OneDrive\Documents\GitHub\CSharp_Projects\CSharp_Projects\Logs\log.txt", number);   //Writes the string to a text file

            Console.WriteLine("Your number has been input into a log file.\nHere is your number read from the saved log file:");   
            string text = File.ReadAllText(@"C:\Users\emily\OneDrive\Documents\GitHub\CSharp_Projects\CSharp_Projects\Logs\log.txt");   //Saves the result of the text file, read back, to a string

            Console.WriteLine(text);   //Writes the text within the text file to the console
            Console.ReadLine();   //Keeps the console open
        }
    }
}
