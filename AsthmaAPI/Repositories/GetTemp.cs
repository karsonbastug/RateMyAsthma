using AsthmaAPI.Data;
using AsthmaAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AsthmaAPI.Repositories
{
    public class GetTemp : IGetTemp
    {
        private readonly DBContextClass _dbContextClass;

        public GetTemp(DBContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<RateByTemp>> GetAverageRatingForTemperatureRange(int MinTemp, int MaxTemp)
        {
            var param1 = new SqlParameter("@MinTemp", MinTemp);
            var param2 = new SqlParameter("@MaxTemp", MaxTemp);
            var getForTempRange = await Task.Run(() => _dbContextClass.RateByTemp.FromSqlRaw("exec GetAverageRatingForTemperatureRange @MinTemp, @MaxTemp;", param1, param2).ToListAsync());
            return getForTempRange;

        }
    }
}
