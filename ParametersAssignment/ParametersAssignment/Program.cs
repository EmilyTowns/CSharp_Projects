using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            List<string> things = new List<string>() { "Book", "Toy", "Plant", "Desk" };

            Employee<int> employee1 = new Employee<int>();
            List<int> things1 = new List<int>() { 1, 3, 5, 9 };

            foreach(string thing in things)
            {
                Console.WriteLine(thing);
            }

            foreach(int thing1 in things1)
            {
                Console.WriteLine(thing1);
            }

            Console.ReadLine();
        }
    }
}
