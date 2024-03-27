using AsthmaAPI.Entities;
using AsthmaAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace AsthmaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class getLocDetailsController : Controller
    {
        private readonly IgetLocDetails getLocDetails;

        public getLocDetailsController(IgetLocDetails getLocDetails)
        {
            this.getLocDetails = getLocDetails;
        }
        [HttpGet("{city}")]
        public async Task<List<LocationWeatherE>> spgetLocDetails(string city)
        {
        var locDetails = await getLocDetails.spgetLocDetails(city);
        if (locDetails == null) 
            {
                //return NotFound();
            }
            return locDetails;
        }
    }
}
