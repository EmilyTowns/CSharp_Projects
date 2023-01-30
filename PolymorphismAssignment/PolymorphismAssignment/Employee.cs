using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Employee : Person, IQuittable   //Creates class, inheriting Person class and IQuittable interface
    {
        public override void SayName()   //Uses method from Person and adds a writeline instruction
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public void Quit()   //Uses method from IQuittable and adds a writeline instruction
        {
            Console.WriteLine("This person has quit.");
        }    
    }
}
