using MercadoLivreSimulacao.Lib.Models;
namespace MercadoLivreSimulacao.Api.DTOs
{
    public class PedidoDTO
    {

        public int IdPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public string StatusPedido { get; set; }
        public int IdTransportadora { get; set; }
        public int IdUsuario { get; set; }


        public virtual Transportadora Transportadora { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Vendedor Vendedor { get; set; }
        public List<ProdutoXPedido> ListaProdutosXPedidos { get; set; }

    }

}