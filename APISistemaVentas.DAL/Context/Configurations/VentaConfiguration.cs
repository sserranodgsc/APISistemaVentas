using APISistemaVentas.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APISistemaVentas.DAL.Context.Configurations
{
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.HasKey(e => e.IdVenta).HasName("PK__Venta__077D56140AF8D801");

            builder.Property(e => e.IdVenta).HasColumnName("idVenta");
            builder.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            builder.Property(e => e.NumeroDocumento)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("numeroDocumento");
            builder.Property(e => e.TipoPago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoPago");
            builder.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");
        }
    }
}
