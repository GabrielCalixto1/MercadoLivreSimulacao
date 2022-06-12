using MercadoLivreSimulacao.Lib.Models;

namespace MercadoLivreSimulacao.Lib.Data.Repositorios.Interface
{
    public interface IProdutoXPedidoRepositorio : IRepositorioBase<ProdutoXPedido>
    {
        void AlterarProduto(int id, int idProduto);
    }
}