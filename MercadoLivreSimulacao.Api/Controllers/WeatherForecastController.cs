using Microsoft.AspNetCore.Mvc;
using MercadoLivreSimulacao.Lib.Data;
namespace MercadoLivreSimulacao.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly MercadoLivreContext _context;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, MercadoLivreContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("Outra")]
    public IActionResult GetTeste()
    {
        return Ok(_context.UsuarioDb.ToList());
    }






    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
