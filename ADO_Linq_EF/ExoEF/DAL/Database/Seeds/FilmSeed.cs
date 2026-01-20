using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Database.Seeds
{
    public class FilmSeed : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasData(
                new Film() { Titre = "Film 1", DateSortie = new DateTime(2020,7,23) },
                new Film() { Titre = "Film 2", DateSortie = new DateTime(2020,7,23) },
                new Film() { Titre = "Film 3", DateSortie = new DateTime(2020,7,23) },
                new Film() { Titre = "Film 4", DateSortie = new DateTime(2020,7,23) },
                new Film() { Titre = "Film 5", DateSortie = new DateTime(2020,7,23) },
                new Film() { Titre = "Film 6", DateSortie = new DateTime(2020,7,23) },
                new Film() { Titre = "Film 7", DateSortie = new DateTime(2020,7,23) }
            );
        }
    }
}
