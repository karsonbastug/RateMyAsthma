using AsthmaAPI.Entities;

namespace AsthmaAPI.Repositories
{
    public interface IAvgRPSByCity
    {
        public Task<List<CitySeasonRating>> avgRatePerSeasonInCity(string city, string season);
    }
}
