using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    public class Math
    {
        public static void math(int num1, int num2)
        {
            int num3 = num1 * num2;
            Console.WriteLine("{0} times {1} equals {2}.", num1, num2, num3);
        }
    }
}
