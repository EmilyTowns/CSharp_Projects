using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string part1 = "Hello, my name is ";   //Creates a string with the first part of a paragraph
            string name = "Emily";   //Creates a string with my name
            string part2 = " and I am working on an assignment.";   //Creates a string with the second part of a paragraph

            name = name.ToUpper();   //Converts the string name to upper case

            string sentence1 = part1 + name + part2;   //Creates a new string that concatenates part1, name, and part2 into one sentence

            //Console.WriteLine(sentence1);   //Writes the sentence to the console
            //Console.ReadLine();   //Keeps the console open

            StringBuilder sb = new StringBuilder();   //Creates a new stringbuilder
            sb.Append(sentence1);   //Appends the sentence to the new stringbuilder

            sb.Append("\nThis is an example of using StringBuilder to append my string.");   //Appends another sentence to sb on a new line

            sb.Append("\nWhen I use it, I am able to continue to add to my string, like this.");   //Appends another sentence to sb on another line   

            sb.Append("\nIt will continue to change the current string instead of creating a new one.");   //Appends last sentence to sb on another line

            Console.WriteLine(sb);   //Writes the stringbuilder paragraph to the console
            Console.ReadLine();   //Keeps the console open
        }
    }
}
