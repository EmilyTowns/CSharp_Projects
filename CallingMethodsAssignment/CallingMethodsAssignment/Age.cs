using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Ages
    {
        public static int Age5()
        {
            int addFive = Program.userInput();
            addFive = addFive + 5;
            return addFive;
        }

        public static int Age10()
        {
            int addTen = Age5();
            addTen = addTen + 5;
            return addTen;
        }

        public static int Age15()
        {
            int addFifteen = Age10();
            addFifteen = addFifteen + 5;
            return addFifteen;
        }
    }
        
    

    
}
