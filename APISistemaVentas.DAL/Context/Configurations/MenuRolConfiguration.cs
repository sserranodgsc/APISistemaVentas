using APISistemaVentas.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APISistemaVentas.DAL.Context.Configurations
{
    public class MenuRolConfiguration : IEntityTypeConfiguration<MenuRol>
    {
        public void Configure(EntityTypeBuilder<MenuRol> builder)
        {
            builder.HasKey(e => e.IdMenuRol).HasName("PK__MenuRol__9D6D61A488CFBCEA");

            builder.ToTable("MenuRol");

            builder.Property(e => e.IdMenuRol).HasColumnName("idMenuRol");
            builder.Property(e => e.IdMenu).HasColumnName("idMenu");
            builder.Property(e => e.IdRol).HasColumnName("idRol");

            builder.HasOne(d => d.IdMenuNavigation).WithMany(p => p.MenuRols)
                .HasForeignKey(d => d.IdMenu)
                .HasConstraintName("FK__MenuRol__idMenu__29572725");

            builder.HasOne(d => d.IdRolNavigation).WithMany(p => p.MenuRols)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__MenuRol__idRol__2A4B4B5E");
        }
    }
}
