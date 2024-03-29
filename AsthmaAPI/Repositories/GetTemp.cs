//Author: Noah Stalnaker
using AsthmaAPI.Data;
using AsthmaAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
namespace AsthmaAPI.Repositories
{
    public class GetTemp
    {
        private readonly DBContextClass _dbContextClass;

        public GetTemp(DBContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<RateByTemp>> spGetAverageRatingForTemperatureRange(string city, List<RateByTemp> getTemp)
        {
            var param = new SqlParameter("@City", city);
            var RateByTemps = await Task.Run(() => _dbContextClass.RateByTemp.FromSqlRaw("exec spGetAverageRatingForTemperatureRange @City;", param).ToListAsync());
            return RateByTemps;
        }
    }
}
