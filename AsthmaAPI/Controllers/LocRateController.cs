// Author: [Your Name]

using AsthmaAPI.Entities;
using AsthmaAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsthmaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationRatingController : ControllerBase
    {
        private readonly GetLocRate _locationRatingRepository;

        public LocationRatingController(GetLocRate locationRatingRepository)
        {
            this.GetLocRate = locationRatingRepository;
        }

        public GetLocRate GetLocRate { get; }

        [HttpGet("{locationId}")]
        public async Task<ActionResult<List<LocationRating>>> GetLocationRatings(int locationId)
        {
            var locationRatings = await _locationRatingRepository.GetLocationRatings(locationId);

            if (locationRatings == null)
            {
                return NotFound();
            }

            return locationRatings;
        }
    }
}
