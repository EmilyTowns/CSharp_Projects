using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public abstract class Person   //Creates abstract class Person, which cannot be instantiated, only inherited
    {
        public string firstName { get; set; }   //Creates two string variables of the class
        public string lastName { get; set; }

        public abstract void SayName();   //Creates abstract SayName method, which cannot be called, only inherited 
    }
}
