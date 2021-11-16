using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Kanapka
    {
        public string warzywa;
        public string pieczywo;
        public string masło;
        public int cena;

        public Kanapka( string warzywa, string pieczywo, string masło, int cena)
        {
            this.warzywa = warzywa;
            this.pieczywo = pieczywo;
            this.masło = masło;
            this.cena = cena;
        }

        public string Details()
        {
            return "Warzywa : "+warzywa + "\nPieczywo : " + pieczywo + "\nMasło : " + masło + "\nDo zapłaty :" + cena;
        }
    }
}
