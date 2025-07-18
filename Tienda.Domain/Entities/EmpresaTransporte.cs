namespace Tienda.Domain.Entities;

public class EmpresaTransporte
{
    public int IdEmpresaTransporte { get; set; }
    public string Nombre { get; set; } = null!;
    public string CorreoContacto { get; set; } = null!;
    public string? Telefono { get; set; }
    public string? Direccion { get; set; }
    public bool Activo { get; set; }

    public ICollection<Importacion> Importaciones { get; set; } = new List<Importacion>();
}
