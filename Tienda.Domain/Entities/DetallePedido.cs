namespace Tienda.Domain.Entities;

public class DetallePedido
{
    public int IdDetallePedido { get; set; }
    public int IdPedido { get; set; }
    public int IdProducto { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }

    public Pedido Pedido { get; set; } = null!;
    public Producto Producto { get; set; } = null!;

    public decimal SubTotal => Cantidad * PrecioUnitario;
}
