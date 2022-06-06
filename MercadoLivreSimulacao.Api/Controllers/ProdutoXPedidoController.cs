using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MercadoLivreSimulacao.Lib.Data;
using MercadoLivreSimulacao.Lib.Models;
using MercadoLivreSimulacao.Api.DTOs;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class ProdutoXPedidoController : ControllerBase
{


    private readonly ILogger<ProdutoXPedidoController> _logger;
    private readonly MercadoLivreContext _context;

    public ProdutoXPedidoController(ILogger<ProdutoXPedidoController> logger, MercadoLivreContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("ListarTodos")]
    public IActionResult ListarTodos()
    {
        var produtoXProdutoXPedidos = _context.ProdutoXPedidoDb.AsNoTracking().ToList();
        return Ok(produtoXProdutoXPedidos);
    }

    [HttpGet("ListarUm")]
    public IActionResult ListarUm(int id)
    {
        var produtoXProdutoXPedido = _context.ProdutoXPedidoDb.Find(id);
        return Ok(produtoXProdutoXPedido);
    }

    [HttpPost("Adicionar")]
    public IActionResult Adicionar(ProdutoXPedidoDTO produtoXProdutoXPedidoDto)
    {
        var produtoXProdutoXPedido = new ProdutoXPedido(produtoXProdutoXPedidoDto.IdProdutoXPedido, produtoXProdutoXPedidoDto.IdProduto, produtoXProdutoXPedidoDto.IdPedido);
        _context.ProdutoXPedidoDb.Add(produtoXProdutoXPedido);
        _context.SaveChanges();
        return Ok(produtoXProdutoXPedido);
    }

    [HttpPut("AlterarValor")]
    public IActionResult AlterarValor(int id, int idProduto)
    {
        var produtoXPedido = _context.ProdutoXPedidoDb.Find(id);
        var produto = _context.ProdutoDb.Find(idProduto);
        produtoXPedido.Produto = produto;
        _context.SaveChanges();
        return Ok("Alteracao bem sucedida!");
    }
    [HttpDelete("Deletar")]
    public IActionResult Deletar(int id)
    {
        var produtoXProdutoXPedido = _context.ProdutoXPedidoDb.Find(id);
        _context.ProdutoXPedidoDb.Remove(produtoXProdutoXPedido);
        _context.SaveChanges();
        return Ok();
    }
}