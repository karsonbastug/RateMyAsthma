using AsthmaAPI.Controllers;
using AsthmaAPI.Data;
using AsthmaAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
//KarsonBastugAPI

namespace AsthmaAPI.Repositories
{
    public class COClass : CityOld
    {
        private readonly DBContextClass _dbContextClass;

        public COClass(DBContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<City2>> AGetLocationOld(string City)
        {
            var param = new SqlParameter("@City", City);
            var locations = await Task.Run(() => _dbContextClass.Old.FromSqlRaw("exec GetCity2 @City;", param).ToListAsync()); 
            return locations;
        }
    }
}
