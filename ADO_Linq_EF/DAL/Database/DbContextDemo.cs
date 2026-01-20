using DAL.Database.Configurations;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Database
{
    public class DbContextDemo : DbContext
    {
        #region entités de la DB
        public DbSet<Car> CarsSet { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //définir la chaine de connexion
            //configure automatiquement quand le "new" est utliser
            optionsBuilder.UseSqlServer("Data Source=GOS-VDI507\\TFTIC;Database=Demo_EFCore;Integrated Security=True;Trust Server Certificate=True; Connect Timeout=10");

            //package nuget commandes :
            /*
             * add-migration <migrationg_name>
             * update-database <migrationg_name>
             * remove-migration <migrationg_name>
             */
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarConfig());
        }
    }
}
