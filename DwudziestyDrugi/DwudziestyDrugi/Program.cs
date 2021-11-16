using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwudziestyDrugi
{
    class Program
    {
        static void Main(string[] args)
        {
            //When Class is static, You can't create instances
            //UsefulTools tools = new UsefulTools();

            Console.WriteLine(Math.Sqrt(144));
            UsefulTools.SayHi("Mike");

            Console.ReadLine();
        }
    }
}
