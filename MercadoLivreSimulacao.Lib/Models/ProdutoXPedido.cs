namespace MercadoLivreSimulacao.Lib.Models
{
    public class ProdutoXPedido
    {
        public int IdProdutoXPedido { get; set; }
        public int IdProduto { get; set; }
        public int IdPedido { get; set; }
        public ProdutoXPedido(int idProdutoXPedido, int idProduto, int idPedido)
        {
            IdProdutoXPedido = idProdutoXPedido;
            IdProduto = idProduto;
            IdPedido = idPedido;
        }
    }
}