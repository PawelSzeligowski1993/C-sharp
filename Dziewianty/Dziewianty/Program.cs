using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziewianty
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;

            if(isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            } else if(isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are tall, but you are not male");
            }
            else if (!isMale && !isTall)
            {
                //Console.WriteLine("You are either not male or not tall or both");
                Console.WriteLine("You are short, but you are not male");
            }

            Console.ReadLine();
        }
    }
}
