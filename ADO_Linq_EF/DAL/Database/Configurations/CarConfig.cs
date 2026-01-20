using Domain.Enums;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Database.Configurations
{
    public class CarConfig : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            //définir le nom de la tablle
            builder.ToTable("Car");

            //définir les colonnes
            builder.Property(c => c.Id)
                    .ValueGeneratedOnAdd();

            builder.Property(c => c.Model)
                    .IsRequired()
                    .HasMaxLength(50);

            builder.Property(c => c.Price)
                    .IsRequired()
                    .HasPrecision(9, 2);

            builder.Property(c => c.RegistrationDate)
                    .HasColumnType("date");

            builder.Property(c => c.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasConversion(
                        v => v.ToString(),
                        v => (CarState) Enum.Parse(typeof(CarState), v));

            //définir les contraintes
            builder.HasKey(c => c.Id)
                    .HasName("PK_Car");

            builder.ToTable(
                t => t.HasCheckConstraint("CK_Car_price", "[Price] >= 0")
            );

            //définir les relations
        }
    }
}
