using System;
using System.Collections.Generic;
using System.Text;

namespace Traveller
{
    public abstract class TravelStratergy
    {
        public int CostPerMile;
        public abstract decimal Travel(int miles);
    }
}
