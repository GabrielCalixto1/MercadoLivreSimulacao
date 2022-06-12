using MercadoLivreSimulacao.Lib.Data.Repositorios.Interface;
using MercadoLivreSimulacao.Lib.Models;
namespace MercadoLivreSimulacao.Lib.Data.Repositorios
{


    public class TransportadoraRepositorio : RepositorioBase<Transportadora>, ITransportadoraRepositorio
    {


        private readonly MercadoLivreContext _context;

        public TransportadoraRepositorio(MercadoLivreContext context) : base(context.TransportadorasDb, context)
        {
            _context = context;
        }
        public void AlterarEmail(int id, string email)
        {
            var transportadora = _context.TransportadorasDb.Find(id);
            transportadora.SetEmail(email);
            _context.SaveChanges();
        }
    }
}