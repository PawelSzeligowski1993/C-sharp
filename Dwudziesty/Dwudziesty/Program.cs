using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwudziesty
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "DOG");

           
            Console.WriteLine(avengers.director);
            Console.WriteLine(avengers.Rating);
            Console.WriteLine(shrek.Rating);
            Console.ReadLine();
        }
    }
}
