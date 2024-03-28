using AsthmaAPI.Entities;
using System.Threading.Tasks;
//KarsonBastugAPI

namespace AsthmaAPI.Repositories
{
    public interface CityReview
    {
        public Task<List<City>> AGetLocation(string City);
    }
}
