using Tienda.Application.DTOs;

namespace Tienda.Application.Interfaces;

public interface ICategoriaService
{
    Task<List<CategoriaDto>> GetAllAsync();
    Task<CategoriaDto?> GetByIdAsync(int id);
    Task<CategoriaDto> CreateAsync(CreateCategoriaDto dto);
}
