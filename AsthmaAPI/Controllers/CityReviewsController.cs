using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using AsthmaAPI.Entities;
using AsthmaAPI.Repositories;
using System.Threading.Tasks;

//KarsonBastugAPI
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
        public async Task<List<City1>> AGetLocation(string City)
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
