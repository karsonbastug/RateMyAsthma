using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using AsthmaAPI.Entities;
using AsthmaAPI.Repositories;
using System.Threading.Tasks;

namespace AsthmaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityReviewController : ControllerBase
    {
        private readonly CityReview aService;

        public CityReviewController(CityReview aService)
        {
            this.aService = aService;
        }

        [HttpGet("{City}")]
        public async Task<List<City>> AGetLocation(string City)
        {
            var locationDetails = await aService.AGetLocation(City);
            if (locationDetails == null)
            {
              //return NotFound();
            }

            return locationDetails;
        }
    }
}
