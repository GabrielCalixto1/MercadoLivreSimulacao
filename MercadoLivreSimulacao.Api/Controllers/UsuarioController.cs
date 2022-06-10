using Microsoft.AspNetCore.Mvc;
using MercadoLivreSimulacao.Lib.Models;
using MercadoLivreSimulacao.Lib.Data.Repositorios;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class UsuarioController : ControllerBase
{


    private readonly ILogger<UsuarioController> _logger;
    private readonly UsuarioRepositorio _repositorio;

    public UsuarioController(ILogger<UsuarioController> logger, UsuarioRepositorio repositorio)
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
    public IActionResult Adicionar(Usuario item)
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
    [HttpPut("AlterarSenha")]
     public IActionResult AlterarSenha(int id, string senha)
    {
        _repositorio.AlterarSenha(id, senha);
        return Ok("Senha alterada com sucesso!!");
    }

}