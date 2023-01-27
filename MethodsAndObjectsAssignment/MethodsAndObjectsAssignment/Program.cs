using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();   //Intantiates an object of employee class
            {
                employee.FirstName = "Sample";   //Assigns values to the properties inherited from the Person class
                employee.LastName = "Student";
                employee.SayName();   //Calls the superclass method SayName(), which will write the name to the console
                Console.ReadLine();   //Keeps console open
            }
        }
    }
}
