namespace Tienda.Domain.Entities;

public class Producto
{
    public int IdProducto { get; set; }
    public string Nombre { get; set; } = null!;
    public string? Descripcion { get; set; }
    public int IdCategoria { get; set; }
    public decimal PrecioCompraYuanes { get; set; }
    public decimal PrecioVentaSoles { get; set; }
    public int Stock { get; set; }
    public DateTime? FechaImportacion { get; set; }
    public int IdProveedor { get; set; }
    public int IdImportacion { get; set; }
    public int IdUnidadMedida { get; set; }

    // Relaciones
    public Categoria Categoria { get; set; } = null!;
    public Proveedor Proveedor { get; set; } = null!;
    public Importacion Importacion { get; set; } = null!;
    public UnidadMedida UnidadMedida { get; set; } = null!;
    public ICollection<DetallePedido> DetallesPedido { get; set; } = new List<DetallePedido>();
    public ICollection<FotoProducto> Fotos { get; set; } = new List<FotoProducto>();
    public VideoProducto? VideoProducto { get; set; }
}
