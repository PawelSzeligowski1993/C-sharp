using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MyProject1
{
    class Cars
    {
        static void Main(string[] args)
        {
            VW_Golf vW_Golf1 = new VW_Golf("Golf1", Type_Engine.Petrol, 50, 1.01, 3, 1973, 9000);
            VW_Golf vW_Golf2 = new VW_Golf("Golf2", Type_Engine.Petrol, 45, 1.01, 3, 1983, 5000);
            VW_Golf vW_Golf3 = new VW_Golf("Golf3", Type_Engine.Diesel, 110, 1.9, 3, 1091, 7000);
            VW_Golf vW_Golf4 = new VW_Golf("Golf4", Type_Engine.Petrol, 75, 1.4, 3, 2001, 4000);
            VW_Golf vW_Golf5 = new VW_Golf("Golf5", Type_Engine.Diesel, 105, 1.9, 5, 2007, 10000);
            VW_Golf vW_Golf6 = new VW_Golf("Golf6", Type_Engine.Petrol, 180, 2.0, 5, 2011, 25000);
            VW_Golf vW_Golf7 = new VW_Golf("Golf7", Type_Engine.Petrol, 140, 1.4, 5, 2015, 35000);
            Polonez polonez = new Polonez(Type_Engine.Petrol, 2000, 130, 5, 5, 1995, 7000, 40);

            polonez.IntroduceSelf();



            VW_Transporter vW_T5 = new VW_Transporter(2.5, 115, 2012, 30000);

            VW_Golf[] vW_Golves = new VW_Golf[7];
            vW_Golves[0] = vW_Golf1;
            vW_Golves[1] = vW_Golf2;
            vW_Golves[2] = vW_Golf3;
            vW_Golves[3] = vW_Golf4;
            vW_Golves[4] = vW_Golf5;
            vW_Golves[5] = vW_Golf6;
            vW_Golves[6] = vW_Golf7;

            Console.WriteLine(vW_Golf7);
            for (int i = 0; i < vW_Golves.Length; i++)
            {
                Console.WriteLine(vW_Golves[i]);
            }

            //VW List
            List<VW_Golf> vW_LIST = new List<VW_Golf>(1);
            vW_LIST.Add(vW_Golf1);
            vW_LIST.Add(vW_Golf2);
            vW_LIST.Add(vW_Golf3);
            vW_LIST.Add(vW_Golf4);
            vW_LIST.Add(vW_Golf5);
            vW_LIST.Add(vW_Golf6);
            vW_LIST.Add(vW_Golf7);
            //vW_LIST.Add(vW_T5);


            //Console.ReadLine();

            Console.WriteLine("Before Sorting");
            foreach (VW_Golf vw in vW_LIST)
            {
                Console.WriteLine(vw.price);
            }

            vW_LIST.Sort();

            Console.WriteLine("After Sorting");
            foreach (VW_Golf vw in vW_LIST)
            {
                Console.WriteLine(vw.price);
            }

            Sort_By_Name sortByName = new Sort_By_Name();
            vW_LIST.Sort(sortByName);
            Console.WriteLine("Sorting by Name");
            foreach (VW_Golf v in vW_LIST)
            {
                Console.WriteLine(v.generations);
            }

            


        }

    }

    /*
     * public Car(Type_Engine type_Engine, double capacityEngine, double enginePower, int personsAmount,
           int doorsAmount, int yearOfProduction, double price)

     *    Console.WriteLine($"Hello my name is Polonez Caro and this are my parameters: " +
                $"type_Engine {type_Engine}"+
                $"Capacity Engine {capacityEngine}" +
                $"Engine Power {enginePower}" +
                $"Persons Amount {personsAmount}" +
                $"Doors Amount {doorsAmount}" +
                $"Year Of Prodution {yearOfProduction}" +
                $"Price {price}" +
                $"Pyrki {pyrkiAmount}"); 
     */




    /*public class SortByName : IComparer<VW_Golf>
    {
        public int Comparer(VW_Golf x, VW_Golf y)
        {
            return x.generations.CompareTo(y.generations);
        }
    }*/

    /*
     public class SortByPower : IComparer<VW_Golf>
     {
         public int Compare(VW_Golf x, VW_Golf y)


             {
                 return x.model.CompareTo(y.model);
             }

     }
    */
}
