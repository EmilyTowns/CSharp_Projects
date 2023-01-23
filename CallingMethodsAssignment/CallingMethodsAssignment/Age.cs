using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Ages   //Creates public class Ages
    {
        public static int Age5(int addFive)   //Creates method and creates a new integer addFive, to which currentAge can be assigned when it is called in the Program class
        { 
            addFive = addFive + 5;   //Adds five years to the input age
            return addFive;   //Returns the new value of addFive, which adds 5 years - this will provide the result when method is called
        }

        public static int Age10(int addTen)   //Creates method and creates a new integer addTen, to which currentAge can be assigned when it is called in the Program class
        {
            addTen = addTen + 10;   //Adds ten years to the input age
            return addTen;   //Returns the new value of addTen, which adds 10 years - this will provide the result when method is called
        }

        public static int Age15(int addFifteen)   //Creates method and creates a new integer addFifteen, to which currentAge can be assigned when it is called in the Program class
        {
            addFifteen = addFifteen + 15;   //Adds fifteen years to the input age
            return addFifteen;   //Returns the new value of addFifteen, which adds 15 years - this will provide the result when method is called
        }
    }   
}
