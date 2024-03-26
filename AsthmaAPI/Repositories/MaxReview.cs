using AsthmaAPI.Entities;
using System.Threading.Tasks;

namespace AsthmaAPI.Repositories
{
    public interface MaxReview
    {
        public Task<List<MaxHealthReview>> AGetTemp(int MaxTemp);
    }
}
