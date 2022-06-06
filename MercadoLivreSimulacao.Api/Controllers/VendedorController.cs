using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MercadoLivreSimulacao.Lib.Data;
using MercadoLivreSimulacao.Lib.Models;
using MercadoLivreSimulacao.Api.DTOs;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class VendedorController : ControllerBase
{


    private readonly ILogger<VendedorController> _logger;
    private readonly MercadoLivreContext _context;

    public VendedorController(ILogger<VendedorController> logger, MercadoLivreContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("ListarTodos")]
    public IActionResult ListarTodos()
    {
        var vendedors = _context.VendedorDb.AsNoTracking().ToList();
        return Ok(vendedors);
    }

    [HttpGet("ListarUm")]
    public IActionResult ListarUm(int id)
    {
        var vendedor = _context.VendedorDb.Find(id);
        return Ok(vendedor);
    }

    [HttpPost("Adicionar")]
    public IActionResult Adicionar(VendedorDTO vendedorDto)
    {
        var vendedor = new Vendedor(vendedorDto.IdVendedor, vendedorDto.Nome, vendedorDto.Email, vendedorDto.Cnpj, vendedorDto.DataCadastro);
        _context.VendedorDb.Add(vendedor);
        _context.SaveChanges();
        return Ok(vendedor);
    }

    [HttpPut("AlterarEmail")]
    public IActionResult AlterarEmail(int id, string email)
    {
        var vendedor = _context.VendedorDb.Find(id);
        vendedor.Email = email;
        _context.SaveChanges();
        return Ok(vendedor);
    }

    [HttpDelete("Deletar")]
    public IActionResult Deletar(int id)
    {
        var vendedor = _context.VendedorDb.Find(id);
        _context.VendedorDb.Remove(vendedor);
        _context.SaveChanges();
        return Ok();
    }
}