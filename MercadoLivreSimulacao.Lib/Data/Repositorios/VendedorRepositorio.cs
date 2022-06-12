using MercadoLivreSimulacao.Lib.Data.Repositorios.Interface;
using MercadoLivreSimulacao.Lib.Models;
namespace MercadoLivreSimulacao.Lib.Data.Repositorios
{


    public class VendedorRepositorio : RepositorioBase<Vendedor>, IVendedorRepositorio
    {


        private readonly MercadoLivreContext _context;

        public VendedorRepositorio(MercadoLivreContext context) : base(context.VendedorDb, context)
        {
            _context = context;
        }
        public void AlterarEmail(int id, string email)
        {
            var vendedor = _context.VendedorDb.Find(id);
            vendedor.Email = email;
            _context.SaveChanges();
        }
    }
}