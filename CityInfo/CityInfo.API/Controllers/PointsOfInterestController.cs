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
            var cityToReturn = CitiesRepository.Current.Cities.FirstOrDefault(
                x => x.Id == cityId);
            if (cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn.PointsOfInterests);
        }
    }
}
