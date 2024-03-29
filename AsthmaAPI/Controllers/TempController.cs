using AsthmaAPI.Entities;
using AsthmaAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace AsthmaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempController : Controller
    {
        private readonly IGetTemp GetTemp;

        public TempController(IGetTemp GetTemp)
        {
            this.GetTemp = GetTemp;
        }
        [HttpGet("{MinTemp}/{MaxTemp}")]

        public async Task<List<RateByTemp>> GetAverageRatingForTemperatureRange(int MinTemp, int MaxTemp)
        {
            var rBT = await GetTemp.GetAverageRatingForTemperatureRange(MinTemp, MaxTemp);
            if (rBT == null)
            {
                //return NotFound();
            }
            return rBT;
        }


    }
}
