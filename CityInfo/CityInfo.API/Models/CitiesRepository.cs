using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class CitiesRepository
    {
        public static CitiesRepository Current { get; set; } = new CitiesRepository();

        public List<CitiesDto> Cities;

        public CitiesRepository()
        {
            Cities = new List<CitiesDto>()
            {
                new CitiesDto()
                {
                    Id = 1,
                    Name = "London",
                    Description = "The one with the big clock",
                    PointsOfInterests = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto
                        {
                            Id = 1,
                            Name = "Tower of London",
                            Description = "Ye Old Dugeon"
                        },
                        new PointsOfInterestDto
                        {
                            Id = 2,
                            Name = "The O2",
                            Description = "Entertainment Arena"
                        }
                    }
                },
                new CitiesDto()
                {
                    Id = 2,
                    Name = "Paris",
                    Description = "The one with the fancy tower",
                    PointsOfInterests = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto
                        {
                            Id = 3,
                            Name = "Eiffel Tower",
                            Description = "19th Centuary Landmark"
                        },
                        new PointsOfInterestDto
                        {
                            Id = 4,
                            Name = "Louvre Museum",
                            Description = "Prestigious Museum"
                        },
                        new PointsOfInterestDto
                        {
                            Id = 5,
                            Name = "Notre-Dame de Paris",
                            Description = "Iconic gothic church"
                        }
                    }
                },
                new CitiesDto()
                {
                    Id = 3,
                    Name = "New York City",
                    Description = "The one with the skyscrapers",
                    PointsOfInterests = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto
                        {
                            Id = 6,
                            Name = "Statue of Liberty",
                            Description = "American icon on New York Harbor"
                        },
                        new PointsOfInterestDto
                        {
                            Id = 7,
                            Name = "Central Park",
                            Description = "Urban Oasis",
                        },
                        new PointsOfInterestDto
                        {
                            Id = 8,
                            Name = "Empire State Building",
                            Description = "103-story landmark"
                        },
                        new PointsOfInterestDto
                        {
                            Id = 9,
                            Name = "Theatre District",
                            Description = "Home of Broadway"
                        }
                    }
                }
            };
        }
    }
}
