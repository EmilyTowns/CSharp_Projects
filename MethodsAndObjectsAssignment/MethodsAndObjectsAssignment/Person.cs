using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Person   //New public class Person
    {
        public string FirstName { get; set; }   //Sets two properties of the class
        public string LastName { get; set; }

        public void SayName()   //Starts a new public void method which will write the full name to console when called
        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine("Name: {0}", FullName);
        }
    }
}
