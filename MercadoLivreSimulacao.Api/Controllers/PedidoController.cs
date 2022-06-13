using Microsoft.AspNetCore.Mvc;
using MercadoLivreSimulacao.Lib.Models;
using MercadoLivreSimulacao.Lib.Data.Repositorios.Interface;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class PedidoController : ControllerBase
{


    private readonly ILogger<PedidoController> _logger;
    private readonly IPedidoRepositorio _repositorio;

    public PedidoController(ILogger<PedidoController> logger, IPedidoRepositorio repositorio)
    {
        _logger = logger;
        _repositorio = repositorio;
    }

    [HttpGet("ListarTodos")]
    public IActionResult ListarTodos()
    {
        
        return Ok(_repositorio.GetTodos());
    }
      [HttpGet("MostrarPorId")]
    public IActionResult MostrarItem(int id)
    {  
        return Ok(_repositorio.MostrarPorId(id));
    }

    [HttpPost("Adicionar")]
    public IActionResult Adicionar(Pedido item)
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
       [HttpPut("AlterarStatus")]
    public IActionResult AlterarStatus(int id, string status)
    {
        _repositorio.AlterarStatus(id, status);
        return Ok("Status alterado!!");
    }
}