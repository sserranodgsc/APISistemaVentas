using APISistemaVentas.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APISistemaVentas.DAL.Context.Configurations
{
    public class NumeroDocumentoConfiguration : IEntityTypeConfiguration<NumeroDocumento>
    {
        public void Configure(EntityTypeBuilder<NumeroDocumento> builder)
        {
            builder.HasKey(e => e.IdNumeroDocumento).HasName("PK__NumeroDo__471E421A0A45C54F");

            builder.ToTable("NumeroDocumento");

            builder.Property(e => e.IdNumeroDocumento).HasColumnName("idNumeroDocumento");
            builder.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            builder.Property(e => e.UltimoNumero).HasColumnName("ultimo_Numero");
        }
    }
}
