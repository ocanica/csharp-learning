using System;
using System.Collections.Generic;
using System.Text;

namespace Traveller.TravelStratergies
{
    public class Bus : TravelStratergy
    {
        public Bus()
        {
            CostPerMile = 20;
        }
        public override decimal Travel(int miles)
        {
            return miles * CostPerMile;
        }
    }
}
