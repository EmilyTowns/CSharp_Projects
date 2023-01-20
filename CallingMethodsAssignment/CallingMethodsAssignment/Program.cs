using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Program
    {
        public static int userInput()
        {
            Console.WriteLine("Let's see how old you will be in 5, 10, and 15 years.");
            Console.WriteLine("Please enter your current age:");
            int currentAge = Convert.ToInt32(Console.ReadLine());
            return currentAge;
        }

        public static void Main(string[] args)
        {
            int five = Ages.Age5();
            Console.WriteLine("In 5 years, you will be " + five + ".");

            int ten = Ages.Age10();
            Console.WriteLine("In 10 years, you will be " + ten + ".");

            int fifteen = Ages.Age15();
            Console.WriteLine("In 15 years, you will be " + fifteen + ".");

            Console.ReadLine();
        }       
        
        
            
        
    }
}
