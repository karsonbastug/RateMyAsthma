// Author: Noah Stalnaker

using AsthmaAPI.Entities;
using AsthmaAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsthmaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateByTempController : ControllerBase
    {
        private readonly RateByTempController _rateByTempRepository;

        public RateByTempController(IGetTemp getTemp)
        {
            this.GetTemp = GetRateByTemperature;
        }

        public Func<int, Task<ActionResult<List<RateByTemp>>>> GetTemp { get; }

        [HttpGet("{temperature}")]
        public async Task<ActionResult<List<RateByTemp>>> GetRateByTemperature(int temperature)
        {
            var rateByTemp = await _rateByTempRepository.GetRateByTemperature(temperature);

            if (rateByTemp == null)
            {
                return NotFound();
            }

            return rateByTemp;
        }
    }
}
