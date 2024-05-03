using APISistemaVentas.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APISistemaVentas.DAL.Context.Configurations
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(e => e.IdCategoria).HasName("PK__Categori__8A3D240C7BD85427");

            builder.Property(e => e.IdCategoria).HasColumnName("idCategoria");
            builder.Property(e => e.EsActivo)
                .HasDefaultValue(true)
                .HasColumnName("esActivo");
            builder.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            builder.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        }
    }
}
