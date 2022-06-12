using MercadoLivreSimulacao.Lib.Models;

namespace MercadoLivreSimulacao.Lib.Data.Repositorios.Interface
{
    public interface IRepositorioBase<T> where T : ModelBase
    {
        public List<T> BuscarTodos();
        
    }
}