using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int meal = 3;
            switch (meal)
            {
                case 1:
                    Console.WriteLine("Chicken Parm");
                    break;
                case 2:
                    Console.WriteLine("Pasta Alfredo");
                    break;
                case 3:
                    Console.WriteLine("Mac and Cheese");
                    break;
                case 4:
                    Console.WriteLine("Burger and Fries");
                    break;
                case 5:
                    Console.WriteLine("Sushi");
                    break;
            }
            Console.ReadLine();
        }
    }
}
