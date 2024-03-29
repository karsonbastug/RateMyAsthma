using AsthmaAPI.Data;
using AsthmaAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AsthmaAPI.Repositories
{
    public interface IGetTemp
    {
        public Task<List<RateByTemp>> GetAverageRatingForTemperatureRange(int MinTemp, int MaxTemp);
    }
}
