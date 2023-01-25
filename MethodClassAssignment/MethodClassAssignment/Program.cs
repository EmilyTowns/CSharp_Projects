using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Math.math(20, 9);

            Math.math(num1: 40, num2: 2);

            Console.ReadLine();
        }
    }
}
