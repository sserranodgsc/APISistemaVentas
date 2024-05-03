using APISistemaVentas.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APISistemaVentas.DAL.Context.Configurations
{
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.HasKey(e => e.IdDetalleVenta).HasName("PK__DetalleV__BFE2843FF106D1D8");

            builder.Property(e => e.IdDetalleVenta).HasColumnName("idDetalleVenta");
            builder.Property(e => e.Cantidad).HasColumnName("cantidad");
            builder.Property(e => e.IdProducto).HasColumnName("idProducto");
            builder.Property(e => e.IdVenta).HasColumnName("idVenta");
            builder.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");
            builder.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");

            builder.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__DetalleVe__idPro__412EB0B6");

            builder.HasOne(d => d.IdVentaNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdVenta)
                .HasConstraintName("FK__DetalleVe__idVen__403A8C7D");
        }
    }
}
