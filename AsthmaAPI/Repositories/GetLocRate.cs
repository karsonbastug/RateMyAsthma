//Author: Noah Stalnaker
using AsthmaAPI.Data;
using AsthmaAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AsthmaAPI.Repositories
{
    public class GetLocRate
    {
        private readonly DBContextClass _dbContextClass;

        public GetLocRate(DBContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<RateByTemp>> spGetRatingForLocations(string city, List<RateByTemp> getLocRate)
        {
            var param = new SqlParameter("@City", city);
            var LocationRating = await Task.Run(() => _dbContextClass.RateByTemp.FromSqlRaw("exec spGetRatingForLocations @City;", param).ToListAsync());
            return LocationRating;
        }

        internal Task<ActionResult<List<LocationRating>>> GetLocationRatings(int locationId)
        {
            throw new NotImplementedException();
        }
    }
}
