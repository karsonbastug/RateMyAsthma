//Author: Chase Baker
using AsthmaAPI.Entities;

namespace AsthmaAPI.Repositories
{
    public interface IgetLocDetails
    {
        public Task<List<LocationWeatherE>> spgetLocDetails(string city);
    }
}
