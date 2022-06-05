using Serilog;
using MercadoLivreSimulacao.Lib.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

   builder.Host.UseSerilog((ctx, lc) => lc
       .WriteTo.Console());

// Add services to the container.
builder.Services.AddDbContext<MercadoLivreContext>(
        conn => conn.UseNpgsql(builder.Configuration.GetConnectionString("MercadoDB"))
    );

builder.Services.AddControllers();
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
