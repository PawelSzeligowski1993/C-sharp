﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedynasty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine("= " + (num1 + num2));
            }else if (op == "-")
            {
                Console.WriteLine("= " + (num1 - num2));
            }
            else if (op == "*")
            {
                Console.WriteLine("= " + (num1 * num2));
            }
            else if (op == "/")
            {
                Console.WriteLine("= " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("User wrote Invalid Opperator");
            }

            Console.ReadLine();
        }
    }
}
