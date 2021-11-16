using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siódmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Kelly";
            friends[2] = "Adam";
            friends[3] = "Paul";
            friends[4] = "John";

            Console.WriteLine(luckyNumbers[0]);
            Console.WriteLine("Array luckyNumbers");

            for(int i=0; i<6; i++)
            {
                Console.WriteLine("Array["+i+"] = "+ luckyNumbers[i]);
            }

            luckyNumbers[0] = 904;
            luckyNumbers[1] = 908;
            luckyNumbers[2] = 915;
            luckyNumbers[3] = 916;
            luckyNumbers[4] = 923;
            luckyNumbers[5] = 942;
            Console.WriteLine("Array luckyNumbers after update");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Array[" + i + "] = " + luckyNumbers[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Array[" + i + "] = " + friends[i]);
            }

            Console.ReadLine();
        }
    }
}
