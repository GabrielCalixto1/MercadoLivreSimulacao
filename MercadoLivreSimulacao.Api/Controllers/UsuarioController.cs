using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MercadoLivreSimulacao.Lib.Data;
using MercadoLivreSimulacao.Lib.Models;
using MercadoLivreSimulacao.Api.DTOs;

namespace ProjetoMercadoLivre.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class UsuarioController : ControllerBase
{


    private readonly ILogger<UsuarioController> _logger;
    private readonly MercadoLivreContext _context;

    public UsuarioController(ILogger<UsuarioController> logger, MercadoLivreContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("ListarTodos")]
    public IActionResult ListarTodos()
    {
        var usuarios = _context.UsuarioDb.AsNoTracking().ToList();
        return Ok(usuarios);
    }

    [HttpGet("ListarUm")]
    public IActionResult ListarUm(int id)
    {
        var usuario = _context.UsuarioDb.Find(id);
        return Ok(usuario);
    }
   

    [HttpPost("Adicionar")]
    public IActionResult Adicionar(UsuarioDTO usuarioDto)
    {
        var usuario = new Usuario(usuarioDto.IdUsuario, usuarioDto.Nome, usuarioDto.Email, usuarioDto.Cpf, usuarioDto.DataNascimento, usuarioDto.Senha);
        _context.UsuarioDb.Add(usuario);
        _context.SaveChanges();
        return Ok(usuario);
    }

    [HttpPut("AlterarSenha")]
     public IActionResult AlterarSenha(int id, string senha)
    {
        var usuario = _context.UsuarioDb.Find(id);
        usuario.Senha = senha;
        _context.SaveChanges();
        return Ok(usuario);
    }

    [HttpDelete("Deletar")]
    public IActionResult Deletar(int id)
    {
        var usuario = _context.UsuarioDb.Find(id);
        _context.UsuarioDb.Remove(usuario);
        _context.SaveChanges();
        return Ok();
    }
}