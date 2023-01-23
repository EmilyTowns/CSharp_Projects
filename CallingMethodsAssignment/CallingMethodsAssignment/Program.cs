using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's see how old you will be in 5, 10, and 15 years.");   //Writes to console
            Console.WriteLine("Please enter your current age:");   //Writes to console asking for user input
            int currentAge = Convert.ToInt32(Console.ReadLine());   //Stores user input, converting to int variable

            int five = Ages.Age5(currentAge);   //Accesses Age class and Age5 method, using currentAge as input for the method
            Console.WriteLine("In 5 years, you will be " + five + ".");   //Writes result to console

            int ten = Ages.Age10(currentAge);   //Accesses Age class and Age10 method, using currentAge as input for the method
            Console.WriteLine("In 10 years, you will be " + ten + ".");   //Writes result to console

            int fifteen = Ages.Age15(currentAge);   //Accesses Age class and Age10 method, using currentAge as input for the method
            Console.WriteLine("In 15 years, you will be " + fifteen + ".");   //Writes result to console

            Console.ReadLine();   //Keeps the console open
        }       
        
        
            
        
    }
}
