namespace MercadoLivreSimulacao.Lib.Models
{
    public class ProdutoXPedido : ModelBase
    {
        public int IdProduto { get; set; }
        public int IdPedido { get; set; }


        public virtual Pedido Pedido {get; set;}
        public virtual Produto Produto {get; set;}
        public ProdutoXPedido(int idProdutoXPedido, int idProduto, int idPedido)  : base(idProdutoXPedido)
        {
       
            IdProduto = idProduto;
            IdPedido = idPedido;
        }
    }
}