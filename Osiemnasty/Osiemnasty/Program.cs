using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osiemnasty
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord Of the Rings", "Tolkien", 700);


            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.pages);

            Console.ReadLine();
        }
    }
}
