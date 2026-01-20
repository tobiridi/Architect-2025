using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Database.Configurations
{
    public class FilmConfig : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.ToTable("Film");

            //colonnes de la table
            builder.Property(f => f.Id)
                .ValueGeneratedOnAdd();

            builder.Property(f => f.Titre)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(f => f.DateSortie)
                .IsRequired();

            //contraintes
            builder.HasKey(f => f.Id)
                    .HasName("PK_Film");

            builder.ToTable(
                t => t.HasCheckConstraint("CK_Film_release", "YEAR([DateSortie]) > 1975")
            );

            builder.HasIndex(k => k.Titre)
                    .IsUnique()
                    .HasDatabaseName("UK_Film_title");
        }
    }
}
