using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwudziewstyTrzeci
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chciken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }

        // This Method can be overridden in any subClases
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}
