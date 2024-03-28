using AsthmaAPI.Entities;
using System.Threading.Tasks;
//KarsonBastugAPI

namespace AsthmaAPI.Repositories
{
    public interface MaxReview
    {
        public Task<List<MaxHealthReview>> AGetTemp(int MaxTemp);
    }
}
