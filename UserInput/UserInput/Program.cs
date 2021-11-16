using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            String age = Console.ReadLine();
            int num2 = Int32.Parse(age);
            Console.WriteLine("Sztywniutko");
            int newAge = num2 + 5;

            Console.WriteLine("You age in 5 years is going to be " + newAge);

            Console.ReadLine();
        }
    }
}
