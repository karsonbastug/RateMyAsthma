using AsthmaAPI.Data;
using AsthmaAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AsthmaAPI.Repositories
{
    public class AvgRatingPerSeasonByCity : IAvgRPSByCity
    {
        private readonly DBContextClass _dbContextClass;

        public AvgRatingPerSeasonByCity(DBContextClass dbContextClass)
        {

            _dbContextClass = dbContextClass;
        }
        public async Task<List<CitySeasonRating>> avgRatePerSeasonInCity(string city, string season)
        {
            var paramA = new SqlParameter("@City", city);
            var paramB = new SqlParameter("@Season", season);
            var getRatingPerSeason = await Task.Run(() => _dbContextClass.CitySeasonRating.FromSqlRaw("exec_avgRatePerSeasonInCity @City, @Season;", paramA, paramB).ToListAsync());
            return getRatingPerSeason;
        }

    }
}
