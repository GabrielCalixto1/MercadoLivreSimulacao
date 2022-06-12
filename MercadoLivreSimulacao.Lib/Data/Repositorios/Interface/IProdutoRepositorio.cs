using MercadoLivreSimulacao.Lib.Models;

namespace MercadoLivreSimulacao.Lib.Data.Repositorios.Interface
{
    public interface IProdutoRepositorio : IRepositorioBase<Produto>
    {
        void AlterarValor(int id, double valor);
    }
}