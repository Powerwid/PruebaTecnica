namespace Tienda.Domain.Entities;

public class Pedido
{
    public int IdPedido { get; set; }
    public int IdCliente { get; set; }
    public int IdEstadoPedido { get; set; }
    public int IdMetodoPago { get; set; }
    public DateTime Fecha { get; set; }
    public decimal? Total { get; set; }

    public Cliente Cliente { get; set; } = null!;
    public EstadoPedido EstadoPedido { get; set; } = null!;
    public MetodoPago MetodoPago { get; set; } = null!;
    public ICollection<DetallePedido> DetallesPedido { get; set; } = new List<DetallePedido>();
}
