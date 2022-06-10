using Microsoft.AspNetCore.Mvc;
using MercadoLivreSimulacao.Lib.Models;
using MercadoLivreSimulacao.Lib.Data.Repositorios;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class ProdutoController : ControllerBase
{


    private readonly ILogger<ProdutoController> _logger;
    private readonly ProdutoRepositorio _repositorio;

    public ProdutoController(ILogger<ProdutoController> logger, ProdutoRepositorio repositorio)
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
    public IActionResult Adicionar(Produto item)
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
    
      [HttpPut("AlterarValor")]
      public IActionResult AlterarValor(int id, double valor)
    {
        _repositorio.AlterarValor(id, valor);
        return Ok("Valor alterado!!");
    }
}