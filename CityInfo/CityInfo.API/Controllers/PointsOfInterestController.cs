using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class PointsOfInterestController : Controller
    {
        [HttpGet("{cityId}/pointsofinterest")]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            var city = CitiesRepository.Current.Cities.FirstOrDefault(
                x => x.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }

            return Ok(city.PointsOfInterests);
        }

        [HttpGet("{cityId}/pointsofinterest/{pointOfInterestId}", Name = "GetPointOfInterest")]
        public IActionResult GetPointOfInterest(int cityId, int pointOfInterestId)
        {
            var city = CitiesRepository.Current.Cities.FirstOrDefault(
                x => x.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }

            var pointOfInterestToReturn = city.PointsOfInterests.FirstOrDefault(
                y => y.Id == pointOfInterestId);

            if (pointOfInterestToReturn == null)
            {
                return NotFound();
            }

            return Ok(pointOfInterestToReturn);
        }

        [HttpPost("{cityId}/pointsofinterest")]
        public IActionResult CreatePointOfInterest(int cityId,
            [FromBody] PointOfInterestForCreationDto pointsOfInterest)
        {
            if (pointsOfInterest == null)
            {
                return BadRequest();
            }

            var city = CitiesRepository.Current.Cities.FirstOrDefault(
                x => x.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }

            int maxPointOfInterestId = CitiesRepository.Current.Cities.SelectMany(
                x => x.PointsOfInterests).Max(y => y.Id);

            var finalPointOfInterest = new PointsOfInterestDto()
            {
                Id = ++maxPointOfInterestId,
                Name = pointsOfInterest.Name,
                Description = pointsOfInterest.Description
            };

            city.PointsOfInterests.Add(finalPointOfInterest);

            return CreatedAtRoute("GetPointOfInterest", new
            { cityId = cityId, pointOfInterestId = finalPointOfInterest.Id }, finalPointOfInterest);
        }
    }
}
