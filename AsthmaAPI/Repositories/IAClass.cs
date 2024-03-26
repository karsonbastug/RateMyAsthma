using AsthmaAPI.Controllers;
using AsthmaAPI.Data;
using AsthmaAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AsthmaAPI.Repositories
{
    public class IAClass : IAs
    {
        private readonly DBContextClass _dbContextClass;

        public IAClass(DBContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<Location>> AGetLocation(string City)
        {
            var param = new SqlParameter("@City", City);
            var locations = await Task.Run(() => _dbContextClass.Location.FromSqlRaw("exec GetCity @City;", param).ToListAsync()); 
            return locations;
        }
    }
}
