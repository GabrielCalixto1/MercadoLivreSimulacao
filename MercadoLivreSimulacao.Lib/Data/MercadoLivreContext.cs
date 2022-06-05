using Microsoft.EntityFrameworkCore;
using MercadoLivreSimulacao.Lib.Models;
namespace MercadoLivreSimulacao.Lib.Data
{
    public class MercadoLivreContext : DbContext
    {
        public MercadoLivreContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produto>().ToTable("NomeTabelaAzure");
            modelBuilder.Entity<Pedido>().ToTable("NomeTabelaAzure");
            modelBuilder.Entity<ProdutoXPedido>().ToTable("NomeTabelaAzure");
            modelBuilder.Entity<Transportadora>().ToTable("NomeTabelaAzure");
            modelBuilder.Entity<Usuario>().ToTable("NomeTabelaAzure");
            modelBuilder.Entity<Vendedor>().ToTable("NomeTabelaAzure");
            
        }
        public DbSet<Produto> ProdutoDb { get; set; }
        public DbSet<Pedido> PedidoDb { get; set; }
        public DbSet<ProdutoXPedido> ProdutoXPedidoDb { get; set; }
        public DbSet<Transportadora> TransportadorasDb { get; set; }
        public DbSet<Usuario> UsuarioDb { get; set; }
        public DbSet<Vendedor> VendedorDb { get; set; }
    }
}