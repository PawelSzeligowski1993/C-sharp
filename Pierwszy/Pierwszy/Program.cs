using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pierwszy
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John";
            int characterAge;
            characterAge = 35;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("but did't like begin " + characterAge);


            Console.WriteLine("Dupa");
            //Console.ReadLine();

            for (int i = 0; i<10; i++)
            {
                Console.WriteLine(i);
              // Console.ReadLine();
            }
             Console.ReadLine();
        }
    }
}
