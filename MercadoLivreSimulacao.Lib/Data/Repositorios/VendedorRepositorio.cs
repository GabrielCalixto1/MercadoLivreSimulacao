using Microsoft.EntityFrameworkCore;
using MercadoLivreSimulacao.Lib.Models;
namespace MercadoLivreSimulacao.Lib.Data.Repositorios
{


    public class VendedorRepositorio : RepositorioBase<Vendedor>
    {


        private readonly MercadoLivreContext _context;

        public VendedorRepositorio(MercadoLivreContext context) : base(context.VendedorDb, context)
        {
            _context = context;
        }
    

    }
}