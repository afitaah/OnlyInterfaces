using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyInterfaces;

public interface IProductModel
{
    string Title { get; set; }
    public bool HasOrderBennCompleted { get; }

   void ShipItem(CustomerModel customer);
}
    
