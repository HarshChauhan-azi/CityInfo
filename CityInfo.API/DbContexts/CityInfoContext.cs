using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;
        public CityInfoContext(DbContextOptions<CityInfoContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(new City("New York City")
            {
                Id=1,
                Description="THe jdjfnks"

            },
            new City("London")
            {
                Id=2,
                Description = "THe jdjfnkssdfs"
            },
            new City("Lisbon")
            { 
                Id = 3,
                Description = "THe jdjfnkssdfsasdfsdfdf"
            });
            modelBuilder.Entity<PointOfInterest>().HasData(new PointOfInterest("Central Park")
            {
                Id=1,
                CityId=1,
                Description = "asdfbhbfsfnksf"
            },
            new PointOfInterest("Central Zoo")
            {
                Id = 2,
                CityId = 1,
                Description = "asdfbhbfsfnksf"
            },
            new PointOfInterest("Central Park")
            {
                Id = 3,
                CityId = 2,
                Description = "asdfbhbfsfnksf"
            },
            new PointOfInterest("Central Park")
            {
                Id = 4,
                CityId = 3,
                Description = "asdfbhbfsfnksf"
            },
            new PointOfInterest("Central Park")
            {
                Id = 5,
                CityId = 3,
                Description = "asdfbhbfsfnksf"
            }
            );
            base.OnModelCreating(modelBuilder);
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("ConnectionString");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
