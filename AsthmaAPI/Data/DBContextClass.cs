using AsthmaAPI.Entities;

using Microsoft.EntityFrameworkCore;

namespace AsthmaAPI.Data

{
    public class DBContextClass : DbContext

    {

        public DBContextClass(DbContextOptions<DBContextClass> options) : base(options)

        { }

        public DbSet<Location> Location { get; set; }
        public DbSet<LocationMoreThanTemp> HealthReview { get; set; }
         
    }

}