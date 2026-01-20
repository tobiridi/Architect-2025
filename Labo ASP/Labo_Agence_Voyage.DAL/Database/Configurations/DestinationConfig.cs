using Labo_Agence_Voyage.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labo_Agence_Voyage.DAL.Database.Configurations
{
    internal class DestinationConfig : IEntityTypeConfiguration<Destination>
    {
        public void Configure(EntityTypeBuilder<Destination> builder)
        {
            builder.ToTable("Destinations");

            builder.Property(d => d.Id)
                .ValueGeneratedOnAdd();

            builder.Property(d => d.Pays)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(d => d.Nom)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(d => d.Description)
                .HasMaxLength(250);

            //contraintes
            builder.HasKey(d => d.Id)
                .HasName("PK_Destinations");

            builder.HasIndex(d => new { d.Nom, d.Pays })
                .IsUnique()
                .HasDatabaseName("UK_Destination_Nom_Pays");
        }
    }
}
