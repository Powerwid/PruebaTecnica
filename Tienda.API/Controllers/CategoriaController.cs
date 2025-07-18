using Microsoft.AspNetCore.Mvc;
using Tienda.Application.DTOs;
using Tienda.Application.Interfaces;

namespace Tienda.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriaController : ControllerBase
{
    private readonly ICategoriaService _service;

    public CategoriaController(ICategoriaService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var categorias = await _service.GetAllAsync();
        return Ok(categorias);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var categoria = await _service.GetByIdAsync(id);
        if (categoria == null) return NotFound();
        return Ok(categoria);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateCategoriaDto dto)
    {
        var nuevaCategoria = await _service.CreateAsync(dto);
        return CreatedAtAction(nameof(Get), new { id = nuevaCategoria.IdCategoria }, nuevaCategoria);
    }
}
