using Microsoft.EntityFrameworkCore;
using Tienda.Application.DTOs;
using Tienda.Application.Interfaces;
using Tienda.Domain.Entities;
using Tienda.Infrastructure.Data;

namespace Tienda.Infrastructure.Services;

public class CategoriaService : ICategoriaService
{
    private readonly TiendaDbContext _context;

    public CategoriaService(TiendaDbContext context)
    {
        _context = context;
    }

    public async Task<List<CategoriaDto>> GetAllAsync()
    {
        return await _context.Categorias
            .Select(c => new CategoriaDto
            {
                IdCategoria = c.IdCategoria,
                Nombre = c.Nombre,
                Descripcion = c.Descripcion
            }).ToListAsync();
    }

    public async Task<CategoriaDto?> GetByIdAsync(int id)
    {
        var categoria = await _context.Categorias.FindAsync(id);
        if (categoria == null) return null;

        return new CategoriaDto
        {
            IdCategoria = categoria.IdCategoria,
            Nombre = categoria.Nombre,
            Descripcion = categoria.Descripcion
        };
    }

    public async Task<CategoriaDto> CreateAsync(CreateCategoriaDto dto)
    {
        var categoria = new Categoria
        {
            Nombre = dto.Nombre,
            Descripcion = dto.Descripcion
        };

        _context.Categorias.Add(categoria);
        await _context.SaveChangesAsync();

        return new CategoriaDto
        {
            IdCategoria = categoria.IdCategoria,
            Nombre = categoria.Nombre,
            Descripcion = categoria.Descripcion
        };
    }
}
