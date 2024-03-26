using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using AsthmaAPI.Entities;
using AsthmaAPI.Repositories;
using System.Threading.Tasks;

namespace AsthmaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LMTTController : ControllerBase
    {
        private readonly LMTT _LocationMoreThan;
        public LMTTController(LMTT _LocationMoreThan)
        {
            this._LocationMoreThan = _LocationMoreThan;
        }
        [HttpGet("{MaxTemp}")]
        public async Task<List<LocationMoreThanTemp>> GetRatingsForHighTemp(int MaxTemp)
        {
            var locationReview = await _LocationMoreThan.GetRatingsForHighTemp(MaxTemp);
            if (locationReview == null)
            {
                // return NotFound();
            }
            return locationReview;
        }
    }
}
