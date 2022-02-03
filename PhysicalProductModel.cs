using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyInterfaces;

public class PhysicalProductModel : IProductModel
{
    public string Title { get; set; }
    public bool HasOrderBennCompleted { get; private set; }
    public void ShipItem(CustomerModel customer)
    {
        if (HasOrderBennCompleted == false)
        {
            Console.WriteLine($"Simulating to {customer.FirstName} in {customer.City}");
            HasOrderBennCompleted = true;
        }
    }
}
