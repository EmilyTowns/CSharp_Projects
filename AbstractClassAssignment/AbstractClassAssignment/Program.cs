using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()   //Instantiates Employee class
            {
                firstName = "Sample",   //Assigns values to firstName and lastName
                lastName = "Student"
            };

            employee.SayName();   //Calls the SayName method, which will write the name to the console
            Console.ReadLine();   //Keeps the console open
        }
    }
}
