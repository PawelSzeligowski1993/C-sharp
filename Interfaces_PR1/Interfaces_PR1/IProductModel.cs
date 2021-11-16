using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_PR1
{
    public interface IProductModel
    {
        string Title { get; set; }

        bool HasOrderBeenCompleted { get; }

        void ShipItem(CustomerModel customer);
    }
}
