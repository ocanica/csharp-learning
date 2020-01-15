using System;
using InterfacesLibrary;
using System.Collections.Generic;

namespace InterfacesUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = AddSampleData();
            var customer = GetCustomer();

            foreach(var prod in cart)
            {
                prod.ShipItem(customer);
            }

            Console.ReadLine();
        }

        private static List<IProductModel> AddSampleData()
        {
            var result = new List<IProductModel>();
            result.Add(new PhysicalProductModel { Title = "USB C Charger" });
            result.Add(new PhysicalProductModel { Title = "Bluetooth Speaker" });
            result.Add(new PhysicalProductModel { Title = "Phone Case" });
            result.Add(new DigitalProductModel { Title = "World of Warcraft" });
            result.Add(new DigitalProductModel { Title = "Toto: Greatest Hits" });

            return result;
        }

        private static Customer GetCustomer()
        {
            return new Customer { 
                FirstName = "Lloyd",
                LastName = "Headbush",
                City = "London",
                EmailAddress = "ocanica@gmail.com",
                PhoneNumber = "0208-123-4567"
            }; 
        }
    }
}
