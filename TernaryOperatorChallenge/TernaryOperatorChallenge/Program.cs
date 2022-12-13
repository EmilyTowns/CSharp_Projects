using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 50;
            int num2 = 25;

            string result = num1 == num2 ? "50 is equal to 25" : "50 is not equal to 25";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
