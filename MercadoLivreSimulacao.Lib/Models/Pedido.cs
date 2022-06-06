namespace MercadoLivreSimulacao.Lib.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public string StatusPedido { get; set; }
        public int IdTransportadora { get; set; }
        public int IdUsuario { get; set; }


        public virtual Transportadora Transportadora {get; set;}
        public virtual Usuario Usuario {get; set;}
        public List<ProdutoXPedido> ListaProdutosXPedidos { get; set; }

        public Pedido(int idPedido, int idTransportadora, int idUsuario, DateTime dataPedido, string statusPedido)
        {
            IdPedido = idPedido;
            IdTransportadora = idTransportadora;
            IdUsuario = idUsuario;
            DataPedido = dataPedido;
            StatusPedido = statusPedido;
        
        }
    }
}