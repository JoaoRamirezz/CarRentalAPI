using Adapters.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adapters.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(e => e.Id)
                .HasName("PK__Categori__F353C1E5ACF1952A");

            builder.Property(e => e.Id)
                .HasColumnName("CategoriaId");

            builder.Property(e => e.Name)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}