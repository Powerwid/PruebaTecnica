using Microsoft.EntityFrameworkCore;
using Tienda.Domain.Entities;

namespace Tienda.Infrastructure.Data;

public class TiendaDbContext : DbContext
{
    public TiendaDbContext(DbContextOptions<TiendaDbContext> options)
        : base(options) { }

    // DbSets (Tablas)
    public DbSet<Categoria> Categorias => Set<Categoria>();
    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<DetallePedido> DetallesPedido => Set<DetallePedido>();
    public DbSet<EstadoPedido> EstadosPedido => Set<EstadoPedido>();
    public DbSet<FotoProducto> FotosProducto => Set<FotoProducto>();
    public DbSet<Importacion> Importaciones => Set<Importacion>();
    public DbSet<EmpresaTransporte> EmpresasTransporte => Set<EmpresaTransporte>();
    public DbSet<MetodoPago> MetodosPago => Set<MetodoPago>();
    public DbSet<Pedido> Pedidos => Set<Pedido>();
    public DbSet<Producto> Productos => Set<Producto>();
    public DbSet<Proveedor> Proveedores => Set<Proveedor>();
    public DbSet<TipoDocumento> TiposDocumento => Set<TipoDocumento>();
    public DbSet<UnidadMedida> UnidadesMedida => Set<UnidadMedida>();
    public DbSet<VideoProducto> VideosProducto => Set<VideoProducto>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // SubTotal no se puede mapear como propiedad calculada en EF directamente (se puede usar Fluent si quieres ignorarla)
        modelBuilder.Entity<DetallePedido>()
            .Ignore(d => d.SubTotal);

        // Relación 1:1 en VideoProducto (PK = FK)
        modelBuilder.Entity<VideoProducto>()
            .HasKey(v => v.IdProducto);

        modelBuilder.Entity<VideoProducto>()
            .HasOne(v => v.Producto)
            .WithOne(p => p.VideoProducto)
            .HasForeignKey<VideoProducto>(v => v.IdProducto);

        // Relaciones adicionales como ON DELETE SET NULL si las aplicaste:
        modelBuilder.Entity<Producto>()
            .HasOne(p => p.Categoria)
            .WithMany(c => c.Productos)
            .HasForeignKey(p => p.IdCategoria)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Producto>()
            .HasOne(p => p.Importacion)
            .WithMany(i => i.Productos)
            .HasForeignKey(p => p.IdImportacion)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Producto>()
            .HasOne(p => p.Proveedor)
            .WithMany(pr => pr.Productos)
            .HasForeignKey(p => p.IdProveedor)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
