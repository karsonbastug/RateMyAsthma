using AsthmaAPI.Controllers;
using AsthmaAPI.Data;
using AsthmaAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
//KarsonBastugAPI

namespace AsthmaAPI.Repositories
{
    public class IRClass : InsertReview
    {
        private readonly DBContextClass _dbContextClass;

        public IRClass(DBContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<InsertR>> InsertReview(int Rating, string Comment, string City)
        {
            var paramB = new SqlParameter("@Rating", Rating);
            var paramA = new SqlParameter("@Comment", Comment);
            var paramC = new SqlParameter("@City", City);
            var areview = await Task.Run(() => _dbContextClass.InsertContext.FromSqlRaw("exec InsertReview  @Rating, @Comment, @City;", paramB, paramA, paramC).ToListAsync());
            return areview;
        }
    }
}
