//Author: Chase Baker﻿
using AsthmaAPI.Data; 
using AsthmaAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AsthmaAPI.Repositories
{
    public class getLocDetails : IgetLocDetails
    {
        private readonly DBContextClass _dbContextClass;

        public getLocDetails(DBContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<LocationWeatherE>> spgetLocDetails(string city)
        {
            var param = new SqlParameter("@City", city);
            var getLocWeather = await Task.Run(() => _dbContextClass.LocationWeatherE.FromSqlRaw("exec spgetLocDetails @City;", param).ToListAsync());
            return getLocWeather;
        }
    }
}
