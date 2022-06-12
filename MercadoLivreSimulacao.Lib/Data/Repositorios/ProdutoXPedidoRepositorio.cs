using MercadoLivreSimulacao.Lib.Data.Repositorios.Interface;
using MercadoLivreSimulacao.Lib.Models;
namespace MercadoLivreSimulacao.Lib.Data.Repositorios
{


    public class ProdutoXPedidoRepositorio : RepositorioBase<ProdutoXPedido>, IProdutoXPedidoRepositorio
    {


        private readonly MercadoLivreContext _context;

        public ProdutoXPedidoRepositorio(MercadoLivreContext context) : base(context.ProdutoXPedidoDb, context)
        {
            _context = context;
        }
        public void AlterarProduto(int id, int idProduto)
        {
            var produtoXPedido = _context.ProdutoXPedidoDb.Find(id);
            var produto = _context.ProdutoDb.Find(idProduto);
            produtoXPedido.Produto = produto;
            _context.SaveChanges();
        }

    }
}