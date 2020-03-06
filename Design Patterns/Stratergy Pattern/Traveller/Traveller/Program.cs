using System;
using Traveller.TravelStratergies;

namespace Traveller
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelPlanner travelPlanner = new TravelPlanner(new Bus());
            travelPlanner.Travel(80);
        }
    }
}
