using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adapters.Configurations;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK__Pagament__977DE7F3FD4262ED");

        builder.ToTable("Pagamento");

        builder.Property(e => e.Id)
            .HasColumnName("PagamentoId");

        builder.Property(e => e.Date)
            .HasColumnName("Data")
            .HasColumnType("datetime");

        builder.Property(e => e.Method)
            .HasColumnName("Metodo")
            .HasMaxLength(20)
            .IsUnicode(false);

        builder.Property(e => e.Status)
            .HasMaxLength(20)
            .IsUnicode(false);

        builder.Property(e => e.Value)
            .HasColumnName("Valor")
            .HasColumnType("decimal(10, 2)");

        builder.HasOne(d => d.Rental).WithMany(p => p.Payments)
            .HasForeignKey(d => d.RentalId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__Pagamento__Locac__5BE2A6F2");
    }
}