using System;
using System.Collections.Generic;
using System.Text;

namespace Traveller.TravelStratergies
{
    public class Airplane : TravelStratergy
    {
        public Airplane()
        {
            CostPerMile = 50;
        }

        public override decimal Travel(int miles)
        {
            if (miles >= 1000)
            {
                CostPerMile = 15;
            }

            return miles * CostPerMile;
        }
    }
}
