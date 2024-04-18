using AsthmaAPI.Entities;
using System.Threading.Tasks;
//KarsonBastugAPI

namespace AsthmaAPI.Repositories
{
    public interface InsertReview
    {
        public Task<List<InsertR>> InsertReview(int Rating, string UserComment, string City);
    }
}
