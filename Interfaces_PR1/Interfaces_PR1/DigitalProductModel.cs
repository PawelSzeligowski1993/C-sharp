using Interfaces_PR1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_PR1
{
    public class DigitalProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        public int TotalDownaldsLeft { get; private set; } = 5;

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating emailing {Title} to {customer.EmailAddress}");
                TotalDownaldsLeft -= 1;
                if (TotalDownaldsLeft < 1)
                {
                    HasOrderBeenCompleted = true;
                    TotalDownaldsLeft = 0;
                }
            }
        }
    }
}
