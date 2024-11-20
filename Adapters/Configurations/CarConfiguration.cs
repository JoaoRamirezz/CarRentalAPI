using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adapters.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(e => e.Id)
                .HasName("PK__Carro__6467B009831ED7AB");

            builder.ToTable("Carro");

            builder.Property(e => e.Id)
                .HasColumnName("Carro_id");

            builder.Property(e => e.CategoryId)
                .HasColumnName("CategoriaId");

            builder.Property(e => e.Manufacturer)
                .HasColumnName("Fabricante")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Model)
                .HasColumnName("Modelo")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.LicensePlate)
                .HasColumnName("Placa")
                .HasMaxLength(7)
                .IsUnicode(false);

            builder.HasOne(d => d.Category).WithMany(p => p.Cars)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Carro__Categoria__4F7CD00D");
        }
    }
}