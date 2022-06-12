using Serilog;
using MercadoLivreSimulacao.Lib.Data;
using MercadoLivreSimulacao.Lib.Data.Repositorios;
using MercadoLivreSimulacao.Lib.Models;
using Microsoft.EntityFrameworkCore;
using MercadoLivreSimulacao.Lib.Data.Repositorios.Interface;

var builder = WebApplication.CreateBuilder(args);

   builder.Host.UseSerilog((ctx, lc) => lc
       .WriteTo.Console());

// Add services to the container.
builder.Services.AddDbContext<MercadoLivreContext>(
        conn => conn.UseNpgsql(builder.Configuration.GetConnectionString("MercadoDB"))
        .UseSnakeCaseNamingConvention()
    );


builder.Services.AddScoped<IPedidoRepositorio, PedidoRepositorio>();
builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
builder.Services.AddScoped<IProdutoXPedidoRepositorio, ProdutoXPedidoRepositorio>();
builder.Services.AddScoped<ITransportadoraRepositorio, TransportadoraRepositorio>();
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

builder.Services.AddControllers()
                .AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
