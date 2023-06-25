using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PetHotelDomain;

namespace PetHotelData
{
    public class PetHotelContext : DbContext, IPetHotelContext
    {
        public DbSet<Cats> Cats { get; set; }

        public PetHotelContext()
        {

        }

        public PetHotelContext(DbContextOptions<PetHotelContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=PetHotelDB")
                    .LogTo(Console.WriteLine,
                           new[] { DbLoggerCategory.Database.Command.Name },
                            LogLevel.Information)
                    .EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //AddDummyData

            var catLists = new Cats[]
            {
                new Cats{CatsId=1,CatName="Lucy", Description="black cat", ArrivalDate=new DateTime(2023,05,01),EstimatedDepartureDate=new DateTime(2023,05,01).AddDays(10), CageLocation="1A",ownerName="Sarah", ownerEmail="sarah123@gmail.com", ownerPhone="8956789" },
                new Cats{CatsId=2,CatName="Winny", Description="fluffy cat", ArrivalDate=new DateTime(2023,04,30),EstimatedDepartureDate=new DateTime(2023,10,01), CageLocation="1D",ownerName="Wiiliam", ownerEmail="william567@gmail.com", ownerPhone="67658978" },
                new Cats{CatsId=3,CatName="Edee", Description="white cat with brown patches", ArrivalDate=new DateTime(2023,05,30),EstimatedDepartureDate=new DateTime(2023,06,30), CageLocation="2A",ownerName="Alex", ownerEmail="alwex@gmail.com", ownerPhone="7677868"},
                new Cats{CatsId=4,CatName="Tuffy", Description="thin cat", ArrivalDate=new DateTime(2023,05,03),EstimatedDepartureDate=new DateTime(2023,08,01), CageLocation="2C" ,ownerName="Alex", ownerEmail="alwex@gmail.com", ownerPhone="7677868"}
            };

            modelBuilder.Entity<Cats>().HasData(catLists);
        }
    }
}