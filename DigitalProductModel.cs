using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyInterfaces;

public class DigitalProductModel : IDigitalProductModel
{
    public String Title { get; set; }

    public bool HasOrderBennCompleted { get; private set; }
    public int TotalDownloadLeft { get; set; } = 5;

    public void ShipItem(CustomerModel customer)
    {
        if (HasOrderBennCompleted == false)
        {
            Console.WriteLine($"Simulating Emailing {Title} in {customer.EmailAddress}");
            TotalDownloadLeft -= 1;
            if (TotalDownloadLeft < 1)
            {
                HasOrderBennCompleted = true;
                TotalDownloadLeft = 0;
            }

        }
    }
}
