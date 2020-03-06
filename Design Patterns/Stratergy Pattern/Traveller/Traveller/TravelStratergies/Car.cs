using System;
using System.Collections.Generic;
using System.Text;

namespace Traveller.TravelStratergies
{
    public class Car : TravelStratergy
    {
        public Car()
        {
            CostPerMile = 25;
        }
        public override decimal Travel(int miles)
        {
            return miles * CostPerMile;
        }
    }
}
