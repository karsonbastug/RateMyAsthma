//Noah Stalnaker
using AsthmaAPI.Entities;

namespace AsthmaAPI.Repositories
{
    public interface IGetLocRate
    {
        public Task<List<RateByTemp>> spGetRatingForLocations(string city);
    }
}
