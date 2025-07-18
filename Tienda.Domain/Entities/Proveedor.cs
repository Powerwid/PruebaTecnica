namespace Tienda.Domain.Entities;

public class Proveedor
{
    public int IdProveedor { get; set; }
    public string Nombre { get; set; } = null!;
    public string? RazonSocial { get; set; }
    public string? DireccionChina { get; set; }
    public string CorreoContacto { get; set; } = null!;
    public string? Telefono { get; set; }

    public ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
