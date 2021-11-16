using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(23);
            list.Add("Hello");

            List<int> ages = new List<int>();
            ages.Add(23);
            ages.Add(25);

            List<Auto> cars = new List<Auto>();
            cars.Add(new Auto("BMW"));
            cars.Add(new Auto("Audi"));
            cars.Add(new Auto("Mercedes"));

            Console.WriteLine();
            Console.Write("Press enter to shut down...");
            Console.ReadLine();
        }
    }

    class Auto
    {
        public string Nazwa { get; set; }
        public Auto(string marka)
        {
            Nazwa = marka;
        }
    }
}
