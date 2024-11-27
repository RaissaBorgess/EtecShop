using EtecShopAPI.Data;
using EtecShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;

namespace EtecShopAPI.Controllers;

[ApiController]
[Route("api/categorias")]
public class CategoriasController(AppDbContext db) : ControllerBase
{
    private readonly AppDbContext _db = db;

    [HttpGet]
    [ProducesResponseType(200)]
    public async Task<IActionResult> Get() => Ok(await _db.Categorias.ToListAsync());

    [HttpGet("{id}")]
    [ProducesResponseType(200)]    
    [ProducesResponseType(404)]  
    public async Task<IActionResult> Get(int id)  =>
        _db.Categorias.Any(c => c.Id == id) ?
        Ok(await _db.Categorias.FindAsync(id)) ;
        NotFound("Categoria não encontrada!");
    
    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Create([FromBody] Categoria categoria)
    {
        if (!ModelState.IsValid)
            return BadRequest("Categoria informada com problemas");
        await _db.Categorias.AddAsync(categoria);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), categoria.Id [FromBody] Categoria categoria)
    }

    }
}