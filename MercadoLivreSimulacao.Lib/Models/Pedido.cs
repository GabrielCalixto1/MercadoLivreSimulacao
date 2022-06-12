namespace MercadoLivreSimulacao.Lib.Models

{
    public class Pedido : ModelBase
    {
        public int IdPedido { get; set; }
        public DateTime DataPedido { get; private set; }
        public string StatusPedido { get; set; }
        public int IdTransportadora { get; set; }
        public int IdUsuario { get; set; }


        public virtual Transportadora Transportadora { get; set; }
        public virtual Usuario Usuario { get; set; }
        public List<ProdutoXPedido> ListaProdutosXPedidos { get; set; }

        public Pedido(int idPedido, int idTransportadora, int idUsuario, DateTime dataPedido, string statusPedido)
        {
            IdPedido = idPedido;
            IdTransportadora = idTransportadora;
            IdUsuario = idUsuario;
            SetData(dataPedido);
            SetStatusPedido(StatusPedido);

        }

        public void SetData(DateTime dataPedido)
        {
            if (DataEMaiorQueDataAtual(dataPedido))
            {
                DataPedido = dataPedido;
            }
        }
        public void SetStatusPedido(string status)
        {
            if (StatusEUmDosObrigatorios(status))
            {
                StatusPedido = status;
            }
        }
        public bool StatusEUmDosObrigatorios(string status)
        {
            if (status == "Em aberto" || status == "Confirmado" || status == "Entregue" || status == "Atrasado")
            {
                return true;
            }
            return false;
        }
    }
}