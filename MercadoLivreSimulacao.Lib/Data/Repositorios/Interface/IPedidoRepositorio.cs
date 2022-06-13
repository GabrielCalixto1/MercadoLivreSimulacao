using MercadoLivreSimulacao.Lib.Models;

namespace MercadoLivreSimulacao.Lib.Data.Repositorios.Interface
{
    public interface IPedidoRepositorio : IRepositorioBase<Pedido>
    {
        void AlterarStatus(int id, string status);
    }
}