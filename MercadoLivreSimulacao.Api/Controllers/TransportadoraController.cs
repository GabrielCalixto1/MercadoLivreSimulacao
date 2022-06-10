using Microsoft.AspNetCore.Mvc;
using MercadoLivreSimulacao.Lib.Models;
using MercadoLivreSimulacao.Lib.Data.Repositorios;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class TransportadoraController : ControllerBase
{


    private readonly ILogger<TransportadoraController> _logger;
    private readonly TransportadoraRepositorio _repositorio;

    public TransportadoraController(ILogger<TransportadoraController> logger, TransportadoraRepositorio repositorio)
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
    public IActionResult Adicionar(Transportadora item)
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
       [HttpPut("AlterarEmail")]
   public IActionResult AlterarEmail(int id, string email)
    {
        _repositorio.AlterarEmail(id, email);
        return Ok("Email alterado com sucesso!!");
    }
}