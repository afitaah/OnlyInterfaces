using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyInterfaces;

public class CustomerModel : ICustomerModel
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
    public string StraetAddress { get; set; }
    public string EmailAddress { get; set; }
    public int PhoneNumber { get; set; }



}
