using AsthmaAPI.Controllers;
using AsthmaAPI.Data;
using AsthmaAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AsthmaAPI.Repositories
{

    public class LMClass : LMTT
    {
        private readonly DBContextClass _dbContext;
        public LMClass(DBContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<LocationMoreThanTemp>> GetRatingsForHighTemp(int MaxTemp)
        {
            var param = new SqlParameter("MaxTemp", MaxTemp);
            var maxtempReview = await Task.Run(() => _dbContext.HealthReview.FromSqlRaw("exec GetRatingsForHighTemp @MaxTemp", param).ToListAsync());
            return maxtempReview;
        }
    }
}
