using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MercadoLivreSimulacao.Lib.Data;
using MercadoLivreSimulacao.Lib.Models;
using MercadoLivreSimulacao.Api.DTOs;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class PedidoController : ControllerBase
{


    private readonly ILogger<PedidoController> _logger;
    private readonly MercadoLivreContext _context;

    public PedidoController(ILogger<PedidoController> logger, MercadoLivreContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("ListarTodos")]
    public IActionResult ListarTodos()
    {
        var pedidos = _context.PedidoDb.AsNoTracking().ToList();
        return Ok(pedidos);
    }

    [HttpGet("ListarUm")]
    public IActionResult ListarUm(int id)
    {
        var pedido = _context.PedidoDb.Find(id);
        return Ok(pedido);
    }

    [HttpPost("Adicionar")]
    public IActionResult Adicionar(PedidoDTO pedidoDto)
    {
        var pedido = new Pedido(pedidoDto.IdPedido, pedidoDto.IdTransportadora, pedidoDto.IdUsuario, pedidoDto.DataPedido, pedidoDto.StatusPedido, pedidoDto.Transportadora, pedidoDto.Usuario, pedidoDto.Vendedor);
        _context.PedidoDb.Add(pedido);
        _context.SaveChanges();
        return Ok(pedido);
    }

    [HttpPut("AlterarStatus")]
    public IActionResult AlterarStatus(int id, string status)
    {
        var pedido = _context.PedidoDb.Find(id);
        pedido.StatusPedido = status;
        _context.SaveChanges();
        return Ok(pedido);
    }

    [HttpDelete("Deletar")]
    public IActionResult Deletar(int id)
    {
        var pedido = _context.PedidoDb.Find(id);
        _context.PedidoDb.Remove(pedido);
        _context.SaveChanges();
        return Ok();
    }
}