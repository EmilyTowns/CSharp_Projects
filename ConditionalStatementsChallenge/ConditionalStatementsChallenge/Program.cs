using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string car = "Challenger";

            if(car == "Corvette")
            {
                Console.WriteLine("You own a Corvette.");
            }
            else if (car == "Challenger")
            {
                Console.WriteLine("You own a Challenger.");
            }
            else if (car == "Mustang")
            {
                Console.WriteLine("You own a Mustang.");
            }
            else
            {
                Console.WriteLine("You do not own a cool car.");
            }
            Console.ReadLine();
        }
    }
}
