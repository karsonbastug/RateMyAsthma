using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using AsthmaAPI.Entities;
using AsthmaAPI.Repositories;
using System.Threading.Tasks;

namespace AsthmaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsthmaController : ControllerBase
    {
        private readonly IAs aService;

        public AsthmaController(IAs aService)
        {
            this.aService = aService;
        }

        [HttpGet("{City}")]
        public async Task<List<Location>> AGetLocation(string City)
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
