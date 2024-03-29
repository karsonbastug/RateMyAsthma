using AsthmaAPI.Data;
using AsthmaAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AsthmaAPI.Repositories
{
    public interface IGetLocRate
    {
        public Task<List<LocationRating>> GetRatingForLocations(int LID);
    }
}
