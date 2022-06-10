namespace MercadoLivreSimulacao.Api.DTOs
{
    public class PedidoDTO
    {

        public int IdPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public string StatusPedido { get; set; }
        public int IdTransportadora { get; set; }
        public int IdUsuario { get; set; }

    }

}