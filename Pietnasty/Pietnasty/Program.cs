using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pietnasty
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            Console.WriteLine("Loop Do-While");
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Loop For");
            for(int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }

            Console.ReadLine();
        }
    }
}
