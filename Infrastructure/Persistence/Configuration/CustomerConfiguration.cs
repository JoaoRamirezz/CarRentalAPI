using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adapters.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK__Cliente__71ABD087D410F494");

        builder.ToTable("Cliente");

        builder.Property(e => e.Id)
            .HasColumnName("ClienteId");

        builder.Property(e => e.Cpf)
            .HasMaxLength(15)
            .IsUnicode(false);

        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .IsUnicode(false);

        builder.Property(e => e.Address)
            .HasColumnName("Endereco")
            .HasMaxLength(150)
            .IsUnicode(false);

        builder.Property(e => e.Name)
            .HasColumnName("Nome")
            .HasMaxLength(100)
            .IsUnicode(false);

        builder.Property(e => e.PhoneNumber)
            .HasColumnName("Telefone")
            .HasMaxLength(15)
            .IsUnicode(false);
    }
}