using System;
using System.Collections.Generic;
using System.Reflection;
using APISistemaVentas.Entities;
using Microsoft.EntityFrameworkCore;

namespace APISistemaVentas.DAL.Context;

public partial class DbventaContext : DbContext
{
    public DbventaContext()
    {
    }

    public DbventaContext(DbContextOptions<DbventaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuRol> MenuRols { get; set; }

    public virtual DbSet<NumeroDocumento> NumeroDocumentos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Venta> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
