using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public static class AClass   //Creates a puclic static class
    {
        public static int thisIsStatic(int num1)   //Creates a public static method, assigning it as an integer
            //Because it cannnot be instantiated, assigning it as an integer makes it useable as a data type itself when called
        {
            int num2 = num1 + 22;   //Performs math on input value
            return num2;   //Returns the result of the math operation
        }
    }
}
