using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var empList = new List<Employee>();   //Creates empty list and adds each employee by calling employee method and inputting the values for each property
            empList.Add(new Employee(1, "Joe", "Lynch"));
            empList.Add(new Employee(2, "Bob", "Reynolds"));
            empList.Add(new Employee(3, "Susan", "Obert"));
            empList.Add(new Employee(4, "Linda", "Richers"));
            empList.Add(new Employee(5, "Fred", "Riddle"));
            empList.Add(new Employee(6, "Joe", "Fredricks"));
            empList.Add(new Employee(7, "Lisa", "Little"));
            empList.Add(new Employee(8, "Emily", "Able"));
            empList.Add(new Employee(9, "Reese", "Roach"));
            empList.Add(new Employee(10, "Lucy", "Best"));

            
            //var joeList = new List<Employee>();   //Creates another new list

            //foreach (Employee emp in empList)   //Starts for each loop for each employee in the employee list
            //{
            //    if (emp.FirstName == "Joe")   //States if the first name property is Joe, to add to the new list and write the name to the console
            //    {
            //        joeList.Add(emp);
            //        Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName);
            //    }    
            //}

            List<Employee> joeList1 = empList.Where(x => x.FirstName.Contains("Joe")).ToList();   //Creates a new list, adding the employees from empList in which the first name contains Joe

            Console.WriteLine("Employees with the first name \"Joe\":");   //Writes to console

            foreach (Employee joe in joeList1)   //Writes the details of the employees on the new list to the console 
            {
                Console.WriteLine(joe.Id + " " + joe.FirstName + " " + joe.LastName);
            }

            List<Employee> idGreaterThanFiveList = empList.Where(x => x.Id > 5).ToList();   //Creates another list, adding employees from empList with an id greater than 5

            Console.WriteLine();   //Blank line for readability
            Console.WriteLine("Employees with ID greater than 5:");   //Writes to console

            foreach (Employee five in idGreaterThanFiveList)   //Writes the details for the employees on the new list to console
            {
                Console.WriteLine(five.Id + " " + five.FirstName + " " + five.LastName);
            }

            Console.ReadLine();   //Keeps console open
        }
    }
}
