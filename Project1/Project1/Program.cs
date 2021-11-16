using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for(int i =0; i<10; i++)
            {
                Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("i = 7");
                }
            }


            Kanapka kanapka = new Kanapka("pomidor", "ciemne", "topione", 5);
            Console.WriteLine(kanapka);
            Console.WriteLine(kanapka.Details());


            VW_Golf golf = new VW_Golf();

            golf.Geer();
            golf.SpeddMax();


            Console.ReadLine();
        }
    }
}
