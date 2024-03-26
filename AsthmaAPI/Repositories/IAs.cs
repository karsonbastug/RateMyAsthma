using AsthmaAPI.Entities;
using System.Threading.Tasks;

namespace AsthmaAPI.Repositories
{
    public interface IAs
    {
        public Task<List<Location>> AGetLocation(string City);
    }
}
