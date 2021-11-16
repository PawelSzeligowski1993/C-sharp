using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziesiec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number1 (int): ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number2 (int): ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number3 (int): ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetMax(num1, num2, num3));

            Console.ReadLine();
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 > num2 && num1 > num3 || num1 > num2 && num1 == num3 || num1 == num2 && num1 > num3)
            {
                result = num1;
            } else if (num2 > num1 && num2 > num3 || num2 == num1 && num2 > num3 || num2 > num1 && num2 == num3)
            {
                result = num2;
            } else if (num3 > num1 && num3 > num2 || num3 == num1 && num3 > num2 || num3 == num1 && num3 > num2)
            {
                result = num3;
            }
            else
            {
                // num1 == num2 == num3
                result = num1;
            }
            return result;
        }
    }
}
