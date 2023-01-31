using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Id1 = new Employee();   //Instatntiates Employee class to demonstrate first employee
            Employee Id2 = new Employee();   //Instatntiates Employee class to demonstrate second employee

            Id1.Id = 1637;   //Sets values for first employees Id and names
            Id1.FirstName = "Susan";
            Id1.LastName = "Sanderson";

            Id2.Id = 9204;   //Sets values for the second employees Id and names
            Id2.FirstName = "George";
            Id2.LastName = "Frankton";

            Console.WriteLine("Employee {0} {1} and employee {2} {3} have the same ID:", Id1.FirstName, Id1.LastName, Id2.FirstName, Id2.LastName);   //Writes the names of the two employees to console
            Console.WriteLine(Id1 == Id2);   //Uses overloaded == operator to compare the two Ids, returning false
            Console.ReadLine();   //Keeps console open
        }
    }
}
