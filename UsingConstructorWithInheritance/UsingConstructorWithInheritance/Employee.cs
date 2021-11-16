using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingConstructorWithInheritance
{
    class Employee : Person
    {
        public Employee(string name) : base(name)
        {
            this.ID = ID;
        }

        public int ID { get; set; }

        public void IntroduceSelf()
        {
            Console.WriteLine($"Hello my name is {Name} and my id is {ID}");
        }
    }
}
