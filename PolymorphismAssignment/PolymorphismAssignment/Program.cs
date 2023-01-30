using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()   //Instantiates class employee and assigns values to firstName and lastName
            {
                firstName = "George",
                lastName = "Sanderson"
            };

            employee.SayName();   //Calls SayName method, which will write name to console

            IQuittable quittable = new Employee();   //Creates quittable using polymorphism

            quittable.Quit();   //Calls Quit method, which displays that the employee has quit

            Console.ReadLine();   //Keeps the console open
        }
    }
}
