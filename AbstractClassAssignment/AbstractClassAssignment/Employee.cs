using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person   //Creates class Employee, inherited from the Person class
    {
        public override void SayName()   //Uses SayName method (which is required)
        {
            Console.WriteLine(firstName + " " + lastName);   //Adds to method a writeline, which will display the name when called
        }
    }
}
