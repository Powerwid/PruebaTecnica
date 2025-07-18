namespace Tienda.Domain.Entities;

public class Importacion
{
    public int IdImportacion { get; set; }
    public string CodigoEmbarque { get; set; } = null!;
    public DateTime? FechaLlega { get; set; }
    public int IdEmpresaTransporte { get; set; }
    public decimal? CostoTotal { get; set; }

    public EmpresaTransporte EmpresaTransporte { get; set; } = null!;
    public ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
