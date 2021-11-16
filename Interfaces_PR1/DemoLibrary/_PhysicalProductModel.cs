using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_PR1
{
    public class _PhysicalProductModel 
    {
        public string Titel { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(_CustomerModel customer)
        {
            if(HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping { Titel } to {customer.FirstName} in {customer.City}");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
