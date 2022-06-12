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

builder.Services.AddScoped<PedidoRepositorio>();
builder.Services.AddScoped<ProdutoRepositorio>();
builder.Services.AddScoped<ProdutoXPedidoRepositorio>();
builder.Services.AddScoped<TransportadoraRepositorio>();
builder.Services.AddScoped<UsuarioRepositorio>();
builder.Services.AddScoped<VendedorRepositorio>();
/*builder.Services.AddScoped<PedidoRepositorio>, <IPedidoRepositorio>();
builder.Services.AddScoped<IRepositorioBase<Produto>,RepositorioBase<Produto>();*/

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
