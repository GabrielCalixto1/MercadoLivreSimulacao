using MercadoLivreSimulacao.Lib.Models;
namespace MercadoLivreSimulacao.Api.DTOs
{
    public class ProdutoXPedidoDTO
    {
        
        public int IdProdutoXPedido { get; set; }
        public int IdProduto { get; set; }
        public int IdPedido { get; set; }


        public virtual Pedido Pedido {get; set;}
        public virtual Produto Produto {get; set;}
    }
}