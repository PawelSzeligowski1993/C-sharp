using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_PR1
{
    interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadsLeft { get; }
    }
}
