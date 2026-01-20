using Labo_Agence_Voyage.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labo_Agence_Voyage.DAL.Database.Configurations
{
    internal class ReservationConfig : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.ToTable("Reservations");

            builder.Property(r => r.Id)
                .ValueGeneratedOnAdd();

            builder.Property(r => r.NomClient)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(r => r.DateReservation)
                .IsRequired()
                .HasColumnType("datetime2");

            //contraintes
            builder.HasKey(r => r.Id)
                .HasName("PK_Reservations");

            //relations
            builder.HasOne(r => r.Destination)
                .WithMany(d => d.Reservations)
                .HasForeignKey("DestinationId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}
