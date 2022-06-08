using Microsoft.EntityFrameworkCore;
using MercadoLivreSimulacao.Lib.Models;
namespace MercadoLivreSimulacao.Lib.Data.Repositorios
{


    public class ProdutoRepositorio : RepositorioBase<Produto>
    {


        private readonly MercadoLivreContext _context;

        public ProdutoRepositorio(MercadoLivreContext context) : base(context.ProdutoDb, context)
        {
            _context = context;
        }
    

    }
}