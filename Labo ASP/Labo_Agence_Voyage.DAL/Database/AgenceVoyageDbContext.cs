using Labo_Agence_Voyage.DAL.Database.Configurations;
using Labo_Agence_Voyage.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Labo_Agence_Voyage.DAL.Database
{
    //La couche "DAL" Configure et gère la persistance des données
    public class AgenceVoyageDbContext : DbContext
    {
        public DbSet<Activiter> Activites { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public AgenceVoyageDbContext(DbContextOptions<AgenceVoyageDbContext> options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DestinationConfig());
            modelBuilder.ApplyConfiguration(new ActiviterConfig());
            modelBuilder.ApplyConfiguration(new ReservationConfig());

        }
    }
}
