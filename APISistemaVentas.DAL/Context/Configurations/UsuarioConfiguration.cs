using APISistemaVentas.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APISistemaVentas.DAL.Context.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(e => e.IdUsuario).HasName("PK__Usuario__645723A69FE87DF0");

            builder.ToTable("Usuario");

            builder.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            builder.Property(e => e.Clave)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("clave");
            builder.Property(e => e.Correo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("correo");
            builder.Property(e => e.EsActivo)
                .HasDefaultValue(true)
                .HasColumnName("esActivo");
            builder.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            builder.Property(e => e.IdRol).HasColumnName("idRol");
            builder.Property(e => e.NombreCompleto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombreCompleto");

            builder.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__Usuario__idRol__2D27B809");
        }
    }
}
