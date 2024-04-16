using AsthmaAPI.Entities;
using System.Threading.Tasks;
//KarsonBastugAPI

namespace AsthmaAPI.Repositories
{
    public interface CityOld
    {
        public Task<List<City2>> AGetLocationOld(string City);
    }
}
