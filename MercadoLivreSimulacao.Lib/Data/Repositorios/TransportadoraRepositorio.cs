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
        public void AlterarEmail(int id, string email)
        {
            var transportadora = _context.TransportadorasDb.Find(id);
            transportadora.Email = email;
            _context.SaveChanges();
        }
    }
}