using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adapters.Configurations;

public class RentalConfiguration : IEntityTypeConfiguration<Rental>
{
    public void Configure(EntityTypeBuilder<Rental> builder)
    {
        builder.HasKey(e => e.Id)
            .HasName("PK__Locacao__31DA8772AB53BD5A");

        builder.ToTable("Locacao");

        builder.Property(x => x.Id)
            .HasColumnName("LocacaoId");

        builder.Property(x => x.CustomerId)
            .HasColumnName("ClienteId");

        builder.Property(x => x.EmployeeId)
            .HasColumnName("FuncionarioId");    

        builder.Property(e => e.CarId)
            .HasColumnName("Carro_id");

        builder.Property(e => e.ReservationId)
            .HasColumnName("ReservaId");

        builder.Property(e => e.DevolutionDate)
            .HasColumnName("DataDevolucao")
            .HasColumnType("datetime");

        builder.Property(e => e.WithdrawalDate)
            .HasColumnName("DataRetirada")
            .HasColumnType("datetime");

        builder.Property(e => e.Status)
            .HasMaxLength(20)
            .IsUnicode(false);

        builder.Property(e => e.TotalValue)
            .HasColumnName("ValorTotal")
            .HasColumnType("decimal(10, 2)");

        builder.HasOne(d => d.Car).WithMany(p => p.Rentals)
            .HasForeignKey(d => d.CarId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__Locacao__Carro_i__5812160E");

        builder.HasOne(d => d.Customer).WithMany(p => p.Rentals)
            .HasForeignKey(d => d.CustomerId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__Locacao__Cliente__571DF1D5");

        builder.HasOne(d => d.Employee).WithMany(p => p.Rentals)
            .HasForeignKey(d => d.EmployeeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__Locacao__Funcion__59063A47");

        builder.HasOne(d => d.Reservation).WithMany(p => p.Rentals)
            .HasForeignKey(d => d.ReservationId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__Locacao__Reserva__5629CD9C");
    }
}