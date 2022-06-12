using MercadoLivreSimulacao.Lib.Models;

namespace MercadoLivreSimulacao.Lib.Data.Repositorios.Interface
{
    public interface IRepositorioBase<T> where T : ModelBase
    {
        List<T> GetTodos();
        T MostrarPorId(int id);
        void AdicionarItem(T item);
        void DeletarPorId(int id);
        
    }
}