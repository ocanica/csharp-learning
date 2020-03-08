using Traveller.Stratergy;

namespace Traveller
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelPlanner travelPlanner = new TravelPlanner(new Diesel());
            travelPlanner.GetAdvisoryFuelRate();
            travelPlanner.ChangeEngineSize(EngineSize.Medium);
            travelPlanner.GetAdvisoryFuelRate();
            travelPlanner.ChangeVehicleType(new Electric());
            travelPlanner.GetAdvisoryFuelRate();
            travelPlanner.ChangeEngineSize(EngineSize.Large);
            travelPlanner.ChangeVehicleType(new Petrol(EngineSize.Large));
            travelPlanner.GetAdvisoryFuelRate();

        }
    }
}
