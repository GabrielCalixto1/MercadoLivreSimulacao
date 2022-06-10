using Microsoft.EntityFrameworkCore;

namespace MercadoLivreSimulacao.Lib.Data.Repositorios
{


    public class RepositorioBase<T> where T : class
    {


        private readonly MercadoLivreContext _context;
        private readonly DbSet<T> _dbset;

        public RepositorioBase(DbSet<T> dbset, MercadoLivreContext context)
        {
            _context = context;
            _dbset = dbset;
        }

        public List<T> GetTodos()
        {
            return (_dbset.AsNoTracking().ToList());
        }

        public T MostrarPorId(int id)
        {
            return (_dbset.Find(id));
        }
        public void AdicionarItem(T item)
        {
            _dbset.Add(item);
            _context.SaveChanges();
            
        }
        public void DeletarPorId(int id)
        {
            var item = _dbset.Find(id);
            _context.Remove(item);
            _context.SaveChanges();

        }

    }
}