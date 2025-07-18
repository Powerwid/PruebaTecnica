namespace Tienda.Domain.Entities;

public class EstadoPedido
{
    public int IdEstadoPedido { get; set; }
    public string Nombre { get; set; } = null!;

    public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
