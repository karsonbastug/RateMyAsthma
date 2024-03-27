using AsthmaAPI.Entities;
using AsthmaAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

using Microsoft.AspNetCore.Mvc;

namespace AsthmaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitySeasonRatingController : Controller
    {
        private readonly IAvgRPSByCity AvgRatingPerSeasonByCity;
        
        public CitySeasonRatingController(IAvgRPSByCity AvgRatingPerSeasonByCity)
        {
            this.AvgRatingPerSeasonByCity = AvgRatingPerSeasonByCity;
        }
        [HttpGet("{city}/{season}")]
      
        public async Task<List<CitySeasonRating>> avgRatePerSeasonInCity(string city, string season)
        {
            var arpsic = await AvgRatingPerSeasonByCity.avgRatePerSeasonInCity(city, season);
            if (arpsic == null)
            {
                //return NotFound();
            }
            return arpsic;
        }
    }
}
