using MercadoLivreSimulacao.Lib.Models;

namespace MercadoLivreSimulacao.Lib.Data.Repositorios.Interface
{
    public interface ITransportadoraRepositorio : IRepositorioBase<Transportadora>
    {
        void AlterarEmail(int id, string email);
    }
}