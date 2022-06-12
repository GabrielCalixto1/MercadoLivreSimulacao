using MercadoLivreSimulacao.Lib.Models;

namespace MercadoLivreSimulacao.Lib.Data.Repositorios.Interface
{
    public interface IVendedorRepositorio : IRepositorioBase<Vendedor>
    {
        void AlterarEmail(int id, string email);
    }
}