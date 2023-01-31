using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee   //Creates public class Employee
    {
        public int Id { get; set; }   //Sets three variables
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator== (Employee Id1, Employee Id2)   //Defines == overload with input of two employees
        {
            bool status = false;   //Sets default status boolean to false
            if (Id1.Id == Id2.Id)   //If the Id of the two employees is the same, changes boolean status to true, otherwise value will remain false
            {
                status = true;
            }
            return status;   //Returns value of status
        }

        public static bool operator !=(Employee Id1, Employee Id2)   //Defines != overload with input of two employees (required with comparison operators)
        {
            bool status = false;   //Sets default status boolean to false
            if (Id1.Id != Id2.Id)    //If the Id of the two employees is not the same, changes boolean status to true, otherwise value will remain false
            {
                status = true;
            }
            return status;   //Returns value of status
        }
    }
}
