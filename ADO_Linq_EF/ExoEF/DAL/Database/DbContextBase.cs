using DAL.Database.Configurations;
using DAL.Database.Seeds;
using Microsoft.EntityFrameworkCore;

namespace DAL.Database
{
    public class DbContextBase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=GOS-VDI507\\TFTIC;Database=Exo_EFCore;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //applique les configurations suivant l'ordre des instructions
            modelBuilder.ApplyConfiguration(new FilmConfig());
            modelBuilder.ApplyConfiguration(new FilmSeed());
        }
    }
}
