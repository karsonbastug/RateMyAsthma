using AsthmaAPI.Entities;
using System.Threading.Tasks;
//KarsonBastugAPI

namespace AsthmaAPI.Repositories
{
    public interface InsertReview
    {
        public Task<List<InsertR>> AInsertReview(string Comment, int Rating, string City);
    }
}
