using Microsoft.EntityFrameworkCore;
using MercadoLivreSimulacao.Lib.Models;
namespace MercadoLivreSimulacao.Lib.Data.Repositorios
{


    public class PedidoRepositorio : RepositorioBase<Pedido>
    {


        private readonly MercadoLivreContext _context;

        public PedidoRepositorio(MercadoLivreContext context) : base(context.PedidoDb, context)
        {
            _context = context;
        }
    

    }
}