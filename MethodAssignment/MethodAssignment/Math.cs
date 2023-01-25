using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class Math   //New public class
    {
        public int math(int num1, int num2 = 0)   //Public method with one optional parameter, which will set to 0 if there is no value
        {
            int num3 = 20;   //Sets num3 to 20
            int num4 = num1 + num2 + num3;   //Adds two input values and num3 and assigns value to num4
            return num4;   //Returns the result
        }
    }
}
