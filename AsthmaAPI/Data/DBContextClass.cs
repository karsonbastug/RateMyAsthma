using AsthmaAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace AsthmaAPI.Data
{
    public class DBContextClass : DbContext
    {
        public DBContextClass(DbContextOptions<DBContextClass> options) : base(options)
        {
        }

        public DbSet<City1> Location { get; set; }
        public DbSet<MaxHealthReview> HealthReview { get; set; }
        public DbSet<LocationWeatherE> LocationWeatherE { get; set; }
        public DbSet<CitySeasonRating> CitySeasonRating { get; set; }
        public DbSet<RateByTemp> RateByTemp { get; set; }
        public DbSet <LocationRating> LocationRating { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure keyless entity type
            modelBuilder.Entity<MaxHealthReview>().HasNoKey();
            modelBuilder.Entity<City1>().HasNoKey();
            modelBuilder.Entity<LocationWeatherE>().HasNoKey();
            modelBuilder.Entity<CitySeasonRating>().HasNoKey();
            modelBuilder.Entity<RateByTemp>().HasNoKey();
            modelBuilder.Entity<LocationRating>().HasNoKey();
        }
    }
}
