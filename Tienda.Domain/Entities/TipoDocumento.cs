namespace Tienda.Domain.Entities;

public class TipoDocumento
{
    public int IdTipoDocumento { get; set; }
    public string Nombre { get; set; } = null!;

    public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
