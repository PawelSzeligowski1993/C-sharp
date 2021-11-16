using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ósmy
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("John", 12);
            SayHi("Mike", 27);
            SayHi("Tom", 27);

            Console.WriteLine(cube(5));

            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello "+ name+ ",You are "+age+" years old");
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }


}
