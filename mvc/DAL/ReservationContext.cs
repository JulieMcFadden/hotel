using mvc.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace mvc.DAL
{
    public class ReservationContext : DbContext
    {

        public ReservationContext() : base("ReservationContext") { }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}