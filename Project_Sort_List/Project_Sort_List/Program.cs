using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Sort_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

            Console.WriteLine("Numbers before sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();

            Console.WriteLine("Numbers after sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Reverse();

            Console.WriteLine("Numbers descending order");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            List<string> alphabets = new List<string>() { "B", "F", "D", "A", "C" };
            Console.WriteLine("Alphabets before sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Sort();

            Console.WriteLine("Alphabets after sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Reverse();

            Console.WriteLine("Alphabets descending order");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Janusz",
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Czesiu",
                Salary = 5500
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Zbyszko",
                Salary = 4500
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Console.WriteLine("Before Sorting");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }

            listCustomers.Sort();
            listCustomers.Reverse();
            Console.WriteLine("after Sorting");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }

            SortByName sortByName = new SortByName();
            listCustomers.Sort(sortByName);
            Console.WriteLine("Sorting by Name");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }

            Comparison<Customer> customerCompare = new Comparison<Customer>(CompareCustomer);
            Console.WriteLine("Before Sorting");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.ID); 
            }

            listCustomers.Sort(customerCompare);

            Console.WriteLine("Before Sorting");
            foreach(Customer c in listCustomers)
            {
                Console.WriteLine(c.ID);
            }

            listCustomers.Sort(delegate (Customer c1, Customer c2) { return c1.ID.CompareTo(c2.ID); });

            Console.WriteLine("After Sorting");
            foreach(Customer c in listCustomers)
            {
                Console.WriteLine(c.ID);
            }
        
            Console.ReadLine();
        }

        private static int CompareCustomer(Customer x, Customer y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }

    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer other)
        {
            if (this.Salary > other.Salary)
                return 1;
            else if (this.Salary < other.Salary)
                return -1;
            else
                return 0;
        }

    }
}
