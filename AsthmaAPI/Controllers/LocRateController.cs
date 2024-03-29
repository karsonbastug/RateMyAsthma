using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using AsthmaAPI.Entities;
using AsthmaAPI.Repositories;
using System.Threading.Tasks;

namespace AsthmaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocRateController : Controller
    {
        private readonly IGetLocRate GetLocRate;

        public LocRateController(IGetLocRate GetLocRate)
        {
            this.GetLocRate = GetLocRate;
        }
        [HttpGet("{LID}")]
        public async Task<List<LocationRating>> GetRatingForLocations(int LID)
        {
            var locRate = await GetLocRate.GetRatingForLocations(LID);
            if (locRate == null)
            {
                //return NotFound();
            }
            return locRate;
        }


    }
}
