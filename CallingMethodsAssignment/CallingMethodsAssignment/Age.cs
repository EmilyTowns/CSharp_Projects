using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Ages
    {
        public static int Age5(int addFive)
        { 
            addFive = addFive + 5;
            return addFive;
        }

        public static int Age10(int addTen)
        {
            addTen = addTen + 10;
            return addTen;
        }

        public static int Age15(int addFifteen)
        {
            addFifteen = addFifteen + 15;
            return addFifteen;
        }
    }   
}
