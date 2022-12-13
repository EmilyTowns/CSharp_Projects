using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");   //Writes title to console

            Console.WriteLine("Please enter package weight in pounds:");   //Writes question to console
            int packageWeight = Convert.ToInt32(Console.ReadLine());   //Assigns user input and converts to integer
            int allowedWeight = 50;   //Assigns an integer to allowedWeight
            
            if (packageWeight > allowedWeight)   //Starts if statement for package weight being bigger than allowed weight
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");   //Writes to console and ends program
                Console.ReadLine();   //Keeps console open
            }
            else
            {
                Console.WriteLine("Please enter package width in inches:");   //Else statement allowing user input for width 
                int packageWidth = Convert.ToInt32(Console.ReadLine());   //Assigns user input and converts to integer
                int allowedWidth = 50;   //Assings an integer to allowedWidth

                if (packageWidth > allowedWidth)   //Starts if statment for package width being bigger than allowed width
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express.");   //Writes to console and ends program
                    Console.ReadLine();   //Keeps console open
                }
                else
                {
                    Console.WriteLine("Please enter package height in inches:");   //Else statement allowing user input for height
                    int packageHeight = Convert.ToInt32(Console.ReadLine());   //Assigns user input and converts to integer
                    int allowedHeight = 50;   //Assings an integer to allowedHeight

                    if (packageHeight > allowedHeight)   //Starts if statment for package height being bigger than allowed height
                    {
                        Console.WriteLine("Package is too big to be shipped via Package Express.");   //Writes to console and ends program
                        Console.ReadLine();   //Keeps console open
                    }
                    else
                    {
                        Console.WriteLine("Please enter package length in inches:");   //Else statement allowing user input for length
                        int packageLength = Convert.ToInt32(Console.ReadLine());   //Assigns user input and converts to integer
                        int allowedLength = 50;   //Assings an integer to allowedLength

                        if (packageLength > allowedLength)   //Starts if statment for package length being bigger than allowed length
                        {
                            Console.WriteLine("Package is too big to be shipped via Package Express.");    //Writes to console and ends program
                            Console.ReadLine();   //Keeps console open
                        }
                        else   //Else statement to continue package quote
                        {
                            decimal quote = (((decimal)packageHeight * (decimal)packageWidth * (decimal)packageLength) * (decimal)packageWeight) / 100;   //Assigns outcome of formula to decimal while convering values to decimal
                            Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ". Thank you!");   //Writes output to console including quote amount
                            Console.ReadLine();   //Keeps console open
                        }
                    }
                }
                
                
            }
        }
    }
}
