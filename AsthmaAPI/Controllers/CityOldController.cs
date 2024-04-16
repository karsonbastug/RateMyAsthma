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
    public class CityOldController : ControllerBase
    {
        private readonly CityOld cService;

        public CityOldController(CityOld cService)
        {
            this.cService = cService;
        }

        [HttpGet("{City}")]
        public async Task<List<City2>> AGetLocationOld(string City)
        {
            var locationDetails = await cService.AGetLocationOld(City);
            if (locationDetails == null)
            {
              //return NotFound();
            }

            return locationDetails;
        }
    }
}
