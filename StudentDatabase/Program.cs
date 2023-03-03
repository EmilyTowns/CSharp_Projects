using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext()) 
            {
                var stud = new Student()
                {
                    StudentName = "Bill",
                };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
