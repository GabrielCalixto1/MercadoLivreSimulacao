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


      public void AlterarValor(int id, double valor)
    {
        var produto = _context.ProdutoDb.Find(id);
        produto.Valor = valor;
        _context.SaveChanges();
    }
    

    }
}