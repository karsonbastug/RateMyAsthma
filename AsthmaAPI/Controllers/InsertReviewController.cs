﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("{Rating}/{Comment}/{City}")]
        public async Task<List<InsertR>> InsertReview(int Rating, string Comment, string City)
        {
            var iD = await bService.InsertReview(Rating, Comment, City);
            if (iD == null)
            {
                //return NotFound();
            }

            return iD;
        }
    }
}
