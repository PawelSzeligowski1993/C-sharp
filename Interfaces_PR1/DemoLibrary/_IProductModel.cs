using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_PR1
{
    public interface _IProductModel
    {
        string Title { get; set; }

        bool HasOrderBeenCompleted { get; }

        void ShipItem(_CustomerModel customer);
    }
}
