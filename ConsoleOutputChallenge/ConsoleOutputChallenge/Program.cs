using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOutputChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 33;
            
            if (age > 17)
            {
                Console.WriteLine("You are an adult.");
            }
            else if (age <= 17)
            {
                Console.WriteLine("You are a child.");
            }
            else
            {
                Console.WriteLine("I don't have your age.");
            }
            Console.ReadLine();
        }
    }
}
