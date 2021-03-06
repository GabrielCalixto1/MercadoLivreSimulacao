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
            modelBuilder.Entity<Produto>().HasKey(key => key.Id);
            modelBuilder.Entity<Produto>()
                        .HasOne(x=> x.Vendedor)
                        .WithMany(x => x.ListaProdutos)
                        .HasForeignKey(x => x.IdVendedor);
           modelBuilder.Entity<Produto>().Property(x => x.DataCadastro).HasColumnName("data_cadastro_produto");
           modelBuilder.Entity<Produto>().Property(x => x.Descricao).HasColumnName("descricao_produto");
           modelBuilder.Entity<Produto>().Property(x => x.Nome).HasColumnName("nome_produto");
           modelBuilder.Entity<Produto>().Property(x => x.Valor).HasColumnName("valor_produto");
           modelBuilder.Entity<Produto>().Property(x => x.Id).HasColumnName("id_produto");
           

            modelBuilder.Entity<Pedido>().ToTable("ml_pedidos");
            modelBuilder.Entity<Pedido>().HasKey(key => key.Id);
            modelBuilder.Entity<Pedido>()
                        .HasOne(x => x.Usuario)
                        .WithMany(x => x.ListaPedidos)
                        .HasForeignKey(x => x.IdUsuario);
            modelBuilder.Entity<Pedido>()
                        .HasOne(x => x.Transportadora)
                        .WithMany(x => x.ListaPedidos)
                        .HasForeignKey(x => x.IdTransportadora);
            modelBuilder.Entity<Pedido>().Property(x => x.Id).HasColumnName("id_pedido");


            modelBuilder.Entity<ProdutoXPedido>().ToTable("ml_produtosxpedidos");
            modelBuilder.Entity<ProdutoXPedido>().HasKey(key => key.Id);
            modelBuilder.Entity<ProdutoXPedido>()
                        .HasOne(x => x.Produto)
                        .WithMany(x => x.ListaProdutosXPedidos)
                        .HasForeignKey(x => x.IdProduto);
            modelBuilder.Entity<ProdutoXPedido>()
                        .HasOne(x => x.Pedido)
                        .WithMany(x => x.ListaProdutosXPedidos)
                        .HasForeignKey(x => x.IdPedido);
            modelBuilder.Entity<ProdutoXPedido>().Property(x => x.Id).HasColumnName("id_produtoxpedido");

                                                                                                  
            modelBuilder.Entity<Transportadora>().ToTable("ml_transportadoras");
            modelBuilder.Entity<Transportadora>().HasKey(key => key.Id);
            modelBuilder.Entity<Transportadora>()
                        .HasMany(x => x.ListaPedidos)
                        .WithOne(x => x.Transportadora)
                        .HasForeignKey(x => x.IdTransportadora);
            modelBuilder.Entity<Transportadora>().Property(x => x.Email).HasColumnName("email_transportadora");
            modelBuilder.Entity<Transportadora>().Property(x => x.Telefone).HasColumnName("telefone_transportadora");
            modelBuilder.Entity<Transportadora>().Property(x => x.Nome).HasColumnName("nome_transportadora");
            modelBuilder.Entity<Transportadora>().Property(x => x.Id).HasColumnName("id_transportadora");
            

            modelBuilder.Entity<Usuario>().ToTable("ml_usuarios");
            modelBuilder.Entity<Usuario>().HasKey(key => key.Id);
            modelBuilder.Entity<Usuario>()
                        .HasMany(x => x.ListaPedidos)
                        .WithOne(x => x.Usuario)
                        .HasForeignKey(x => x.IdUsuario);
            modelBuilder.Entity<Usuario>().Property(x => x.Email).HasColumnName("email_usuario");
            modelBuilder.Entity<Usuario>().Property(x => x.Id).HasColumnName("id_usuario");

            modelBuilder.Entity<Vendedor>().ToTable("ml_vendedores");
            modelBuilder.Entity<Vendedor>().HasKey(key => key.Id);
            modelBuilder.Entity<Vendedor>()
                        .HasMany(x => x.ListaProdutos)
                        .WithOne(x => x.Vendedor)
                        .HasForeignKey(x => x.IdVendedor) ; 
            modelBuilder.Entity<Vendedor>().Property(x => x.Id).HasColumnName("id_vendedor");
            
        }
        public DbSet<Produto> ProdutoDb { get; set; }
        public DbSet<Pedido> PedidoDb { get; set; }
        public DbSet<ProdutoXPedido> ProdutoXPedidoDb { get; set; }
        public DbSet<Transportadora> TransportadorasDb { get; set; }
        public DbSet<Usuario> UsuarioDb { get; set; }
        public DbSet<Vendedor> VendedorDb { get; set; }
    }
}