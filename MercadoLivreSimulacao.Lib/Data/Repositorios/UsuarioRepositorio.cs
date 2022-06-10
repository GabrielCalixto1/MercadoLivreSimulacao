using MercadoLivreSimulacao.Lib.Models;
namespace MercadoLivreSimulacao.Lib.Data.Repositorios
{


    public class UsuarioRepositorio : RepositorioBase<Usuario>
    {


        private readonly MercadoLivreContext _context;

        public UsuarioRepositorio(MercadoLivreContext context) : base(context.UsuarioDb, context)
        {
            _context = context;
        }
        public void AlterarSenha(int id, string senha)
        {
            var usuario = _context.UsuarioDb.Find(id);
            usuario.Senha = senha;
            _context.SaveChanges();
        }

    }
}