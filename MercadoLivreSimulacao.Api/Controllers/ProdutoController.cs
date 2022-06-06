using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MercadoLivreSimulacao.Lib.Data;
using MercadoLivreSimulacao.Lib.Models;
using MercadoLivreSimulacao.Api.DTOs;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class ProdutoController : ControllerBase
{


    private readonly ILogger<ProdutoController> _logger;
    private readonly MercadoLivreContext _context;

    public ProdutoController(ILogger<ProdutoController> logger, MercadoLivreContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("ListarTodos")]
    public IActionResult ListarTodos()
    {
        var produtos = _context.ProdutoDb.AsNoTracking().ToList();
        return Ok(produtos);
    }

    [HttpGet("ListarUm")]
    public IActionResult ListarUm(int id)
    {
        var produto = _context.ProdutoDb.Find(id);
        return Ok(produto);
    }

    [HttpPost("Adicionar")]
    public IActionResult Adicionar(ProdutoDTO produtoDto)
    {
        var produto = new Produto(produtoDto.IdProduto, produtoDto.IdVendedor, produtoDto.Nome, produtoDto.Descricao, produtoDto.Valor, produtoDto.DataCadastro);
        _context.ProdutoDb.Add(produto);
        _context.SaveChanges();
        return Ok(produto);
    }

    [HttpPut("AlterarProduto")]
      public IActionResult AlterarValor(int id, double valor)
    {
        var produto = _context.ProdutoDb.Find(id);
        produto.Valor = valor;
        _context.SaveChanges();
        return Ok(produto);
    }

    [HttpDelete("Deletar")]
    public IActionResult Deletar(int id)
    {
        var produto = _context.ProdutoDb.Find(id);
        _context.ProdutoDb.Remove(produto);
        _context.SaveChanges();
        return Ok();
    }
}