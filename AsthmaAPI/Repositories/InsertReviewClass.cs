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

        public async Task<List<InsertR>> AInsertReview(string Comment, int Rating, string City)
        {
            var paramA = new SqlParameter("@Comment", Comment);
            var paramB = new SqlParameter("@Rating", Rating);
            var paramC = new SqlParameter("@City", City);
            var areview = await Task.Run(() => _dbContextClass.InsertContext.FromSqlRaw("exec InsertReview @Comment, @Rating, @City;", paramA, paramB, paramC).ToListAsync()); 
            return areview;
        }
    }
}
