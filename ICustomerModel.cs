namespace OnlyInterfaces;

public interface ICustomerModel
{
    string City { get; set; }
    string EmailAddress { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    int PhoneNumber { get; set; }
    string StraetAddress { get; set; }
}