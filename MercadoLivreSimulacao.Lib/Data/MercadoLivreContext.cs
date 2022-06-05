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
            
            
            modelBuilder.Entity<Produto>().ToTable("ml_produtos");
            modelBuilder.Entity<Produto>().HasKey(key => key.IdProduto);
            modelBuilder.Entity<Produto>()
                        .HasOne(x=> x.Vendedor)
                        .WithMany(x => x.ListaProdutos)
                        .HasForeignKey(x => x.IdVendedor);


            modelBuilder.Entity<Pedido>().ToTable("ml_pedidos");
            modelBuilder.Entity<Pedido>().HasKey(key => key.IdPedido);
            modelBuilder.Entity<Pedido>()
                        .HasOne(x => x.Usuario)
                        .WithMany(x => x.ListaPedidos)
                        .HasForeignKey(x => x.IdUsuario);
            modelBuilder.Entity<Pedido>()
                        .HasOne(x => x.Transportadora)
                        .WithMany(x => x.ListaPedidos)
                        .HasForeignKey(x => x.IdTransportadora);
        

            modelBuilder.Entity<ProdutoXPedido>().ToTable("ml_produtosxpedidos");
            modelBuilder.Entity<ProdutoXPedido>().HasKey(key => key.IdProdutoXPedido);
            modelBuilder.Entity<ProdutoXPedido>()
                        .HasOne(x => x.Produto)
                        .WithMany(x => x.ListaProdutosXPedidos)
                        .HasForeignKey(x => x.IdProduto);
            modelBuilder.Entity<ProdutoXPedido>()
                        .HasOne(x => x.Pedido)
                        .WithMany(x => x.ListaProdutosXPedidos)
                        .HasForeignKey(x => x.IdPedido);
                                                                                                  
            modelBuilder.Entity<Transportadora>().ToTable("ml_transportadoras");
            modelBuilder.Entity<Transportadora>().HasKey(key => key.IdTransportadora);
            modelBuilder.Entity<Transportadora>()
                        .HasMany(x => x.ListaPedidos)
                        .WithOne(x => x.Transportadora);

            modelBuilder.Entity<Usuario>().ToTable("ml_usuarios");
            modelBuilder.Entity<Usuario>().HasKey(key => key.IdUsuario);
            modelBuilder.Entity<Usuario>()
                        .HasMany(x => x.ListaPedidos)
                        .WithOne(x => x.Usuario);

            modelBuilder.Entity<Vendedor>().ToTable("ml_vendedores");
            modelBuilder.Entity<Vendedor>().HasKey(key => key.IdVendedor);
            modelBuilder.Entity<Vendedor>()
                        .HasMany(x => x.ListaProdutos)
                        .WithOne(x => x.Vendedor);            
            
        }
        public DbSet<Produto> ProdutoDb { get; set; }
        public DbSet<Pedido> PedidoDb { get; set; }
        public DbSet<ProdutoXPedido> ProdutoXPedidoDb { get; set; }
        public DbSet<Transportadora> TransportadorasDb { get; set; }
        public DbSet<Usuario> UsuarioDb { get; set; }
        public DbSet<Vendedor> VendedorDb { get; set; }
    }
}