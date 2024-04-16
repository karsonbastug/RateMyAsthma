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
    public class InsertReviewController : ControllerBase
    {
        private readonly Repositories.InsertReview bService;

        public InsertReviewController(Repositories.InsertReview bService)
        {
            this.bService = bService;
        }

        [HttpGet("{Comment}/{Rating}/{City}")]
        public async Task<List<InsertR>> AInsertReview(string Comment, int Rating, string City)
        {
            var iD = await bService.AInsertReview(Comment, Rating, City);
            if (iD == null)
            {
              //return NotFound();
            }

            return iD;
        }
    }
}
