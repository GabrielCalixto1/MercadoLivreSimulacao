using MercadoLivreSimulacao.Lib.Data.Repositorios.Interface;
using MercadoLivreSimulacao.Lib.Models;
namespace MercadoLivreSimulacao.Lib.Data.Repositorios
{


    public class UsuarioRepositorio : RepositorioBase<Usuario>, IUsuarioRepositorio
    {


        private readonly MercadoLivreContext _context;

        public UsuarioRepositorio(MercadoLivreContext context) : base(context.UsuarioDb, context)
        {
            _context = context;
        }
        public void AlterarSenha(int id, string senha)
        {
            var usuario = _context.UsuarioDb.Find(id);
            usuario.SetSenha(senha);
            _context.SaveChanges();
        }

    }
}