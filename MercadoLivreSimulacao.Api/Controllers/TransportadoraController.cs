using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MercadoLivreSimulacao.Lib.Data;
using MercadoLivreSimulacao.Lib.Models;
using MercadoLivreSimulacao.Api.DTOs;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class TransportadoraController : ControllerBase
{


    private readonly ILogger<TransportadoraController> _logger;
    private readonly MercadoLivreContext _context;

    public TransportadoraController(ILogger<TransportadoraController> logger, MercadoLivreContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("ListarTodos")]
    public IActionResult ListarTodos()
    {
        var transportadoras = _context.TransportadorasDb.AsNoTracking().ToList();
        return Ok(transportadoras);
    }

    [HttpGet("ListarUm")]
    public IActionResult ListarUm(int id)
    {
        var transportadora = _context.TransportadorasDb.Find(id);
        return Ok(transportadora);
    }

    [HttpPost("Adicionar")]
    public IActionResult Adicionar(TransportadoraDTO transportadoraDto)
    {
        var transportadora = new Transportadora(transportadoraDto.IdTransportadora, transportadoraDto.Nome, transportadoraDto.Telefone, transportadoraDto.Email);
        _context.TransportadorasDb.Add(transportadora);
        _context.SaveChanges();
        return Ok(transportadora);
    }

    [HttpPut("AlterarEmail")]
   public IActionResult AlterarEmail(int id, string email)
    {
        var transportadora = _context.TransportadorasDb.Find(id);
        transportadora.Email = email;
        _context.SaveChanges();
        return Ok(transportadora);
    }

    [HttpDelete("Deletar")]
    public IActionResult Deletar(int id)
    {
        var transportadora = _context.TransportadorasDb.Find(id);
        _context.TransportadorasDb.Remove(transportadora);
        _context.SaveChanges();
        return Ok();
    }
}