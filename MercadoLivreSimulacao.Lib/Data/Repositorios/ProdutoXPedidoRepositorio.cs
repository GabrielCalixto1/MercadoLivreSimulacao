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
    

    }
}