using System;
using System.Collections.Generic;
using System.Text;

namespace Traveller
{
    public class TravelPlanner
    {
        private readonly TravelStratergy _travelStratergy;

        public TravelPlanner(TravelStratergy travelStratergy)
        {
            _travelStratergy = travelStratergy;
        }

        public void Travel(int miles)
        {
            var cost = _travelStratergy.Travel(miles);
            Console.WriteLine($"Cost of travel: {cost}");
        }
    }
}
