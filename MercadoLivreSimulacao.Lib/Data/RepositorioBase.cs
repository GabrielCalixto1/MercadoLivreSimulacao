using MercadoLivreSimulacao.Lib.Models;
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
            _dbset =  dbset;
        }

        public List<T> GetTodos()
        {
            var getlista = _dbset.ToList();
            return getlista;
        }
           public void MostrarItemPorID(T item)
        {
            _dbset.Find(item);
            _context.SaveChanges();
        }
        public void SalvarItem(T item)
        {
            _dbset.Add(item);
            _context.SaveChanges();
        }
           public void DeletarItem(T item)
        {
            _dbset.Remove(item);
            _context.SaveChanges();
        }

   
    }
}