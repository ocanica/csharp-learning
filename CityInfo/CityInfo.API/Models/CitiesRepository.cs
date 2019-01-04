using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class CitiesRepository
    {
        public List<CityDto> Cities;
        public static CitiesRepository Current { get; } = new CitiesRepository();

        public CitiesRepository()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "London",
                    Description = "The one with Big Ben"
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "New York City",
                    Description = "The one with the Skyscrapers"
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Cape Town",
                    Description = "The one with the flat Mountain"
                }
            };
        }
    }
}
