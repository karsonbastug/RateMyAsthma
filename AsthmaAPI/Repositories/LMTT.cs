using AsthmaAPI.Entities;
using System.Threading.Tasks;


namespace AsthmaAPI.Repositories
{
    public interface LMTT
    {
        public Task<List<LocationMoreThanTemp>> GetRatingsForHighTemp(int MaxTemp);
    }
}