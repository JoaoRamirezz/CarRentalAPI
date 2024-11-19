using Adapters.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adapters.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id)
                .HasName("PK__Funciona__297ECCAAF8D468AE");

            builder.ToTable("Funcionario");

            builder.Property(x => x.Id)
                .HasColumnName("FuncionarioId");

            builder.Property(e => e.Role)
                .HasColumnName("Cargo")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Cpf)
                .HasMaxLength(11)
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
}