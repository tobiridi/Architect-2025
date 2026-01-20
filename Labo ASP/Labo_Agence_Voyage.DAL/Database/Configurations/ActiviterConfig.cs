using Labo_Agence_Voyage.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labo_Agence_Voyage.DAL.Database.Configurations
{
    internal class ActiviterConfig : IEntityTypeConfiguration<Activiter>
    {
        public void Configure(EntityTypeBuilder<Activiter> builder)
        {
            builder.ToTable("Activites");

            builder.Property(a => a.Id)
                .ValueGeneratedOnAdd();

            builder.Property(a => a.Nom)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(a => a.Description)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(a => a.Prix)
                .HasColumnType("decimal(10,2)")
                .HasPrecision(10,2);

            //contraintes
            builder.HasKey(a => a.Id)
                .HasName("PK_Activites");

            //relations
            builder.HasOne(a => a.Destination)
                .WithMany(d => d.Activites)
                .HasForeignKey("DestinationId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}
