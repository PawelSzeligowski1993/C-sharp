using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piaty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (int): ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number (int): ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);

            Console.Write("Enter a number (double): ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number (double): ");
            double num4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num3 + num4);

            Console.ReadLine();
        }
    }
}
