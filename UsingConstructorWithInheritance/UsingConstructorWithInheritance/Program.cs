using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingConstructorWithInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Edek = new Employee("Edek");

            List<Person> emps = new List<Person>();

            Student s = new Student("");
            s.Name = "Jesse";
            s.Age = 15;
            s.GradelLevel = 8;

            Employee e = new Employee("Bob");
            e.Age = 50;
            e.ID = 9;

            emps.Add(s);
            emps.Add(e);

           
        }
    }
}
