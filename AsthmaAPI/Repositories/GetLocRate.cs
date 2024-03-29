using AsthmaAPI.Data;
using AsthmaAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace AsthmaAPI.Repositories
{
    public class GetLocRate : IGetLocRate
    {
        private readonly DBContextClass _dbContextClass;

        public GetLocRate(DBContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<LocationRating>> GetRatingForLocations(int LID)
        {
            var param = new SqlParameter("@LID", LID);
            var getLocationRating = await Task.Run(() => _dbContextClass.LocationRating.FromSqlRaw("exec GetRatingForLocations @LID;", param).ToListAsync());
            return getLocationRating;
        }

    }
}
