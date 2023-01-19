using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Age
    {
        public int age;
        
        public void Age5(int input)
        {
            Age age5 = new Age();
            age5.age = input;
            Console.WriteLine("In 5 years, you will be " + age5.age + ".");
        }

        public void Age10(int input)
        {
            Age age10 = new Age();
            age10.age = input;
            Console.WriteLine("In 10 years, you will be " + age10.age + ".");
        }

        public void Age15(int input)
        {
            Age age15 = new Age();
            age15.age = input;
            Console.WriteLine("In 15 years, you will be " + age15.age + ".");
        }
    }
}
