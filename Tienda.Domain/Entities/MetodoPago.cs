namespace Tienda.Domain.Entities;

public class MetodoPago
{
    public int MetodoPagoId { get; set; }
    public string Nombre { get; set; } = null!;
    public bool Activo { get; set; }

    public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
