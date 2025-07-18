namespace Tienda.Domain.Entities;

public class VideoProducto
{
    public int IdProducto { get; set; }
    public string Url { get; set; } = string.Empty;

    public Producto? Producto { get; set; }
}
