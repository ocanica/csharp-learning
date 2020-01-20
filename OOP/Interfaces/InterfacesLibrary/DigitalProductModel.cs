using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesLibrary
{
    public class DigitalProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool OrderCompleted { get; private set; }

        public int DownloadsRemaining { get; private set; } = 5;

        public void ShipItem(Customer customer)
        {
            if (!OrderCompleted)
            {
                Console.WriteLine($"Emailing { Title } to { customer.EmailAddress }");
                DownloadsRemaining -= 1;

                if(DownloadsRemaining < 1)
                {
                    OrderCompleted = true;
                    DownloadsRemaining = 0;
                }
            }
        }
    }
}
