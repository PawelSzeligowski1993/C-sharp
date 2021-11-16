using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_PR1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (PhysicalProductModel prod in cart)
            {
                Console.WriteLine(prod.HasOrderBeenCompleted);
                prod.ShipItem(customer);
                Console.WriteLine(prod.HasOrderBeenCompleted);
            }

            Console.ReadLine();
        }


        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Tim",
                LastName = "Corey",
                StreetAddress = "Green Street",
                City = "Scranton",
                EmailAddress = "tim@IAmTimCorey.com",
                PhoneNumber = "555-1212"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "IAmTimCorey T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new PhysicalProductModel { Title = "Blue Monday" });
            output.Add(new DigitalProductModel { Title = "Blue Monday" });

            return output;
        }
    }
}
