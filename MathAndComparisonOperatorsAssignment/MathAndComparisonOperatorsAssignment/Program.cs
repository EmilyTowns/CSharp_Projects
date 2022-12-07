using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");   //Writes title to console

            Console.WriteLine("Person 1");   //Writes to console
            Console.WriteLine("Enter Person 1 hourly rate:");   //Prompts user to enter hourly rate
            double person1Rate = Convert.ToDouble(Console.ReadLine());   //Assigns response converted to double
            Console.WriteLine("Enter Person 1 hours worked per week:");   //Prompts user to enter hours worked per week
            double person1Hours = Convert.ToDouble(Console.ReadLine());   //Assigns response converted to double   

            Console.WriteLine("Person 2");   //Writes to console
            Console.WriteLine("Enter Person 2 hourly rate:");   //Prompts user to enter hourly rate
            double person2Rate = Convert.ToDouble(Console.ReadLine());   //Assigns response converted to double
            Console.WriteLine("Enter Person 2 hours worked per week:");   //Prompts user to enter hours worked per week
            double person2Hours = Convert.ToDouble(Console.ReadLine());   //Assigns response converted to double

            double person1Salary = (person1Rate * person1Hours) * 52;   //Calculates annual salary of person 1
            Console.WriteLine("Annual salary of Person 1: " + person1Salary);   //Writes person 1 salary to console

            double person2Salary = (person2Rate * person2Hours) * 52;   //Calculate annual salary of person 2
            Console.WriteLine("Annual salary of Person 2: " + person2Salary);   //Writes person 2 salary to console

            Console.WriteLine("Person 1 makes more money than Person 2");   //Writes to console
            bool compareSalary = person1Salary > person2Salary;   //Assigns boolean comparing if person 1 salary is more than person 2
            Console.WriteLine(compareSalary);   //Writes boolean response to console
            Console.ReadLine();   //Keeps console open

        }
    }
}
