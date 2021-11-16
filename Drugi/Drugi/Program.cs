using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase1 = "Giraffe Academy";
            string phrase2 = " is cool";
            string sumPhrase = phrase1 + phrase2;
            char grade = 'A';
            int age = 30;
            double gpa = 3.3;
            bool isMale = false;

            Console.WriteLine(30);
            Console.WriteLine(sumPhrase);
            Console.WriteLine(sumPhrase.ToUpper());
            Console.WriteLine(sumPhrase.ToLower());
            Console.WriteLine(sumPhrase.IndexOf('A'));
            Console.ReadLine();
        }
    }
}
