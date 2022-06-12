using MercadoLivreSimulacao.Lib.Data.Repositorios.Interface;
using MercadoLivreSimulacao.Lib.Models;
namespace MercadoLivreSimulacao.Lib.Data.Repositorios
{


    public class PedidoRepositorio : RepositorioBase<Pedido>, IPedidoRepositorio
    {


        private readonly MercadoLivreContext _context;

        public PedidoRepositorio(MercadoLivreContext context) : base(context.PedidoDb, context)
        {
            _context = context;
        }

        public void AlterarStatus(int id, string status)
        {
            var item = _context.PedidoDb.Find(id);
            item.StatusPedido = status;
            _context.SaveChanges();
        }

    }
}