namespace Tienda.Domain.Entities;

public class Cliente
{
    public int IdCliente { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public int IdTipoDocumento { get; set; }
    public string NumeroDocumento { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public string? DireccionEnvio { get; set; }
    public string? Telefono { get; set; }

    public TipoDocumento? TipoDocumento { get; set; }
    public ICollection<Pedido>? Pedidos { get; set; }
}
