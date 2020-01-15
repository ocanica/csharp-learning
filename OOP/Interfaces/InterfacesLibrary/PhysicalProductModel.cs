using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesLibrary
{
    public class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }
        public bool OrderCompleted { get; private set; }

        public void ShipItem(Customer customer)
        {
            if (!OrderCompleted)
            {
                Console.WriteLine($"Now shipping { Title } to { customer.FirstName } in { customer.City }");
                OrderCompleted = true;
            } else
            {
                Console.WriteLine($"{ Title } has already been delivered.");
            }
            
        }
    }
}
