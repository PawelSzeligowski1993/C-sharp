using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwudziewstyTrzeci
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChicken();

            ItalianChef italian = new ItalianChef();
            italian.MakeSpagetti();

            italian.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}
