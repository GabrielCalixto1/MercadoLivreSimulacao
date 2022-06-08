using Microsoft.EntityFrameworkCore;
using MercadoLivreSimulacao.Lib.Models;
namespace MercadoLivreSimulacao.Lib.Data.Repositorios
{


    public class TransportadoraRepositorio : RepositorioBase<Transportadora>
    {


        private readonly MercadoLivreContext _context;

        public TransportadoraRepositorio(MercadoLivreContext context) : base(context.TransportadorasDb, context)
        {
            _context = context;
        }
    

    }
}