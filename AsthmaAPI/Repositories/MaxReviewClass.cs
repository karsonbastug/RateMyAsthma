using AsthmaAPI.Controllers;
using AsthmaAPI.Data;
using AsthmaAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AsthmaAPI.Repositories
{
    public class MaxReviewClass : MaxReview
    {
        private readonly DBContextClass _dbContextClass;

        public MaxReviewClass(DBContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<MaxHealthReview>> AGetTemp(int MaxTemp)
        {
            var param = new SqlParameter("@MaxTemp", MaxTemp);
            var maxR = await Task.Run(() => _dbContextClass.HealthReview.FromSqlRaw("exec GetRatingsForHighTemp @MaxTemp;", param).ToListAsync());
            return maxR;
        }
    }
}
