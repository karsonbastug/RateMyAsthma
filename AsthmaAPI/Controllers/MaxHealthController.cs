using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using AsthmaAPI.Entities;
using AsthmaAPI.Repositories;
using System.Threading.Tasks;

namespace AsthmaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaxHealthController : ControllerBase
    {
        private readonly MaxReview bService;

        public MaxHealthController(MaxReview bService)
        {
            this.bService = bService;
        }

        [HttpGet("{MaxTemp}")]
        public async Task<List<MaxHealthReview>> AGetTemp(int MaxTemp)
        {
            var tDetail = await bService.AGetTemp(MaxTemp);
            if (tDetail == null)
            {
                //return NotFound();
            }

            return tDetail;
        }
    }
}
