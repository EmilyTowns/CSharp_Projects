using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class User   //Makes public user class
    {
        public string FirstName { get; set; }   //Sets first and last name properties of class user
        public string LastName { get; set; }

        public User(string FirstName) : this(FirstName, "Doe")   //Chains constructor in the case of a user not having a last name to input, assigning generic last name as Doe
        {
            this.FirstName = FirstName;   
            Console.WriteLine("New user: {0}", FirstName);   //Would write only first name to console
        }

        public User(string FirstName, string LastName)   //Used if there is a first and last name input
        {
            this.FirstName = FirstName;   //Input first and last name is equal to corresponding properties
            this.LastName = LastName;
            Console.WriteLine("New user: {0} {1}", FirstName, LastName);   //Writes first and last name to console
        }
    }
}
