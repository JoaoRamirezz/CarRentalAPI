using Adapters.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adapters.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Reserva__C399376365B93271");

            builder.ToTable("Reserva");

            builder.Property(e => e.Id)
                .HasColumnName("ReservaId");

            builder.Property(e => e.CarId)
                .HasColumnName("CarroId");

            builder.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("Data_fim");

            builder.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("Data_inicio");

            builder.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.HasOne(d => d.Car).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reserva__Carro_i__534D60F1");

            builder.HasOne(d => d.Customer).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reserva__Cliente__52593CB8");
        }
    }
}