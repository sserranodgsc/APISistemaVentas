using APISistemaVentas.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APISistemaVentas.DAL.Context.Configurations
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(e => e.IdMenu).HasName("PK__Menu__C26AF483B75794A1");

            builder.ToTable("Menu");

            builder.Property(e => e.IdMenu).HasColumnName("idMenu");
            builder.Property(e => e.Icono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("icono");
            builder.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            builder.Property(e => e.Url)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("url");
        }
    }
}
