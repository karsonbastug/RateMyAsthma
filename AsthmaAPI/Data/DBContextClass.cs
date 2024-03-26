using AsthmaAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace AsthmaAPI.Data
{
    public class DBContextClass : DbContext
    {
        public DBContextClass(DbContextOptions<DBContextClass> options) : base(options)
        {
        }

        public DbSet<City> Location { get; set; }
        public DbSet<MaxHealthReview> HealthReview { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure keyless entity type
            modelBuilder.Entity<MaxHealthReview>().HasNoKey();
            modelBuilder.Entity<City>().HasNoKey();
        }
    }
}
