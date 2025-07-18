namespace Tienda.Domain.Entities;

public class FotoProducto
{
    public int IdFotoProducto { get; set; }
    public int IdProducto { get; set; }
    public string Url { get; set; } = null!;

    public Producto Producto { get; set; } = null!;
}
