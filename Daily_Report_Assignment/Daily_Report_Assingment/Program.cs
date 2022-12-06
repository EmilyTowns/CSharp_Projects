using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_Assingment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College");   //Write title to the console
            Console.WriteLine("Student Daily Report");   //Write subtitle to the console

            Console.WriteLine("What is your name?");   //Write question 1 to console
            string name = Console.ReadLine();    //Save response as string  

            Console.WriteLine("What course are you on?");   //Write question 2 to console
            string course = Console.ReadLine();    //Save response as string

            Console.WriteLine("What page number?");   //Write question 3 to console
            int page = Convert.ToInt32(Console.ReadLine());    //Save response as integer

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");   //Write question 4 to console
            bool help = Convert.ToBoolean(Console.ReadLine());    //Save response as boolean

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");   //Write question 5 to console
            string posFeedback = Console.ReadLine();    //Save response as string

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");   //Write question 6 to console
            string feedback = Console.ReadLine();    //Save response as string

            Console.WriteLine("How many hours did you study today?");   //Write question 7 to console
            int hours = Convert.ToInt32(Console.ReadLine());    //Save response as integer

            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
            Console.Read();

        }
    }
}
