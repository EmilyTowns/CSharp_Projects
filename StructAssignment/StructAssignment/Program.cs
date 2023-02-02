using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    struct Number   //Creates struct
    {
        public decimal Amount;   //Creates a decimal property
    }

    class Program
    {
        static void Main(string[] args)
        {
            Number num1;   //Creates an object of the struct Number 
            num1.Amount = 9000000;   //Assigns value to the Amount property

            Console.WriteLine(num1.Amount);   //Writes this amount to console
            Console.ReadLine();   //Keeps console open
        }
    }
}
