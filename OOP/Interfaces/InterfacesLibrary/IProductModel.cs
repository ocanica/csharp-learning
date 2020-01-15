using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesLibrary
{
    public interface IProductModel
    {
        string Title { get; set; }

        bool OrderCompleted { get; }

        void ShipItem(Customer customer);
    }
}
