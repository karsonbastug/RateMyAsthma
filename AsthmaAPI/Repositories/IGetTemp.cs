//Noah Stalnaker
using AsthmaAPI.Entities;

namespace AsthmaAPI.Repositories
{
    public interface IGetTemp
    {
        public Task<List<RateByTemp>> spGetAverageRAtingForTempuratureRange(string city);
    }
}
