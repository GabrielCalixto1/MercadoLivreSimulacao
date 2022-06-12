using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MercadoLivreSimulacao.Lib.Data;
using MercadoLivreSimulacao.Lib.Models;
using MercadoLivreSimulacao.Api.DTOs;
using MercadoLivreSimulacao.Lib.Data.Repositorios.Interface;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class ProdutoXPedidoController : ControllerBase
{


    private readonly ILogger<ProdutoXPedidoController> _logger;
    private readonly IProdutoXPedidoRepositorio _repositorio;

    public ProdutoXPedidoController(ILogger<ProdutoXPedidoController> logger, IProdutoXPedidoRepositorio repositorio)
    {
        _logger = logger;
        _repositorio = repositorio;
    }

    [HttpGet("ListarTodos")]
    public IActionResult ListarTodos()
    {

        return Ok(_repositorio.GetTodos);
    }
    [HttpGet("MostrarPorId")]
    public IActionResult MostrarItem(int id)
    {
        return Ok(_repositorio.MostrarPorId(id));
    }

    [HttpPost("Adicionar")]
    public IActionResult Adicionar(ProdutoXPedido item)
    {
        _repositorio.AdicionarItem(item);
        return Ok("Adicionado item com sucesso!!");
    }

    [HttpDelete("Deletar")]
    public IActionResult DeletarPorId(int id)
    {
        _repositorio.DeletarPorId(id);
        return Ok("Deletado com sucesso!!");
    }

    [HttpPut("AlterarProduto")]
    public IActionResult AlterarProduto(int id, int idProduto)
    {
        _repositorio.AlterarProduto(id, idProduto);
        return Ok("Valor alterado com sucesso!!");
    }
}