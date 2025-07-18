namespace Tienda.Domain.Entities;

public class UnidadMedida
{
    public int IdUnidadMedida { get; set; }
    public string Nombre { get; set; } = null!;
    public string Abreviatura { get; set; } = null!;

    public ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
