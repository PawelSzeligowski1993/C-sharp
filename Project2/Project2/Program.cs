using System;

namespace Project2
{
    class Program
    {
        /*
         * ------------------------------ Interfaces ------------------------------
        */
        interface IItem
        {
            string name { get; set; }

            void Equip();
            void Sell();
        }

        interface IDamageble
        {
            int durability { get; set; }
            void TakeDamage(int amount);

        }

        interface IPartofQuest
        {
            void TurnIn();
        }

        /*
         * ------------------------------ Class ------------------------------
        */
        class Sword : IItem, IDamageble, IPartofQuest
        {
            public string name { get; set; }
            public int goldValue { get; set; }
            public int durability { get; set; }

            public Sword(string name)
            {
                this.name = name;
                goldValue = 100;
                durability = 60;
            }
            public void Sell()
            {
                Console.WriteLine(name + " equipped. ");
            }

            public void Equip()
            {
                Console.WriteLine(name + " sold for " + goldValue + " imaginary dollars");
            }

            public void TakeDamage(int dmg)
            {
                durability -= dmg;
                Console.WriteLine(name + " damaged by " + dmg + ". It now has a durability of "+ durability);
            }

            public void TurnIn()
            {
                Console.WriteLine(name + " turned in.");
            } 
        }

        class Axe : IItem, IDamageble, IPartofQuest
        {
            public string name { get; set; }
            public int goldValue { get; set; }
            public int durability { get; set; }

            public Axe(string name)
            {
                this.name = name;
                goldValue = 70;
                durability = 80;

            }
            public void Sell()
            {
                Console.WriteLine(name + " equipped. ");
            }

            public void Equip()
            {
                Console.WriteLine(name + " sold for " + goldValue + " imaginary dollars");
            }

            public void TakeDamage(int dmg)
            {
                durability -= dmg;
                Console.WriteLine(name + " damaged by " + dmg + ". It now has a durability of " + durability);
            }

            public void TurnIn()
            {
                Console.WriteLine(name + "turned in (it was an axe).");
            }
        }

        /*
        * ------------------------------ Main Class ------------------------------
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.ReadKey();

            Sword sword = new Sword("Sword of Destiny");
            sword.Equip();
            sword.TakeDamage(20);
            sword.Sell();
            sword.TurnIn();

            Console.WriteLine();

            Axe axe = new Axe("Fury Axe");
            axe.Equip();
            axe.TakeDamage(10);
            axe.Sell();
            //Console.ReadKey();
            Console.WriteLine();

            //Create an inventory 
            IItem[] inventory = new IItem[2];
            inventory[0] = sword;
            inventory[1] = axe;
            Console.WriteLine();

            //Loop through and turn in all quest items
            for(int i = 0; i < inventory.Length; i++)
            {
                IPartofQuest questItem = inventory[i] as IPartofQuest;
                if (questItem != null)
                {
                    questItem.TurnIn();
                }
            }

            Console.ReadLine();
        }
    }
}
