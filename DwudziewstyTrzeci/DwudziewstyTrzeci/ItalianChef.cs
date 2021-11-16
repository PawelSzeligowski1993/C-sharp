using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwudziewstyTrzeci
{
    class ItalianChef : Chef
    {
        public void MakeSpagetti()
        {
            Console.WriteLine("Italian Chef makes Spagetti");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("Italian Chef makes bbq ribs");
        }
    }
}
