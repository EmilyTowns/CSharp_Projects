using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    public class Employee   //Creates new public class with three properties
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(int id, string firstName, string lastName)   //Creates method with input properties, assigning those to the class properties 
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
