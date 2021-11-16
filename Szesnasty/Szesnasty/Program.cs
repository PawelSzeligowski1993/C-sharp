using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szesnasty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Get num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetPow(num1, num2));
            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for(int i =0; i<powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }
    }
}
