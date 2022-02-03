using System.Collections.Generic;
using OnlyInterfaces;


public class program
{
    static void Main(string[] args)
    {
        List<IProductModel> card = AddSampleData();
        CustomerModel customer = GetCustomer();

        foreach (IProductModel productModel in card)
        {

            productModel.ShipItem(customer);
            if (productModel is IDigitalProductModel digital)
            {
                Console.WriteLine($"For The {digital.Title} you have :{digital.TotalDownloadLeft} download left.");
            }
            //Console.WriteLine($"PhysicalProductModel {physicalProductModel}");//Extra code
        }
        
    }


    private static CustomerModel GetCustomer()
    {
        return new CustomerModel
        {
            FirstName = "Tim",
            LastName = "abdifitah",
            City = "Mugdisho",
            EmailAddress = "a.caaqil20@gmail.com",
            PhoneNumber = 612044116
        };
    }

    private static List<IProductModel> AddSampleData()
    {
        List<IProductModel> outpur = new List<IProductModel>();
        outpur.Add(new PhysicalProductModel {Title ="Title One" });
        outpur.Add(new PhysicalProductModel { Title = "Title Two" });
        outpur.Add(new PhysicalProductModel { Title = "Title Three" });
        outpur.Add(new DigitalProductModel {Title ="Lesson Source Code ."});


        return outpur; 
    }

}
