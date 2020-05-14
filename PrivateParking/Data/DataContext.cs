using PrivateParking.Models;
using System.Data.Entity;

namespace PrivateParking
{
    public class DataContext : DbContext
    {
        //public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public System.Data.Entity.DbSet<Customer> Customer { get; set; }
        public DbSet<ParkingLot> ParkingLot { get; set; }
        public DbSet<ParkingType> ParkingType { get; set; }
        public DbSet<ParkingBlock> ParkingBlock { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //}

    }
}
