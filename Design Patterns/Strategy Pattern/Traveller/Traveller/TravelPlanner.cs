using System;
using System.Collections.Generic;
using System.Text;
using Traveller.Stratergy;

namespace Traveller
{
    public class TravelPlanner
    {
        private IAdvisoryFuelRate _advisoryFuelRate;

        public TravelPlanner(IAdvisoryFuelRate advisoryFuelRate)
        {
            _advisoryFuelRate = advisoryFuelRate;
        }

        public void ChangeVehicleType(IAdvisoryFuelRate advisoryFuelRate)
            => _advisoryFuelRate = advisoryFuelRate;

        public void ChangeEngineSize(EngineSize engineSize)
            => _advisoryFuelRate.ChangeEngineSize(engineSize);

        public void GetAdvisoryFuelRate()
        {
            Console.WriteLine($"The AVL for a {_advisoryFuelRate.engineSize} {_advisoryFuelRate.EngineType} engine " +
                $"is: {_advisoryFuelRate.PencePerMile} per mile");
        }
    }
}
