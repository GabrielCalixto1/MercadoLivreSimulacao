using MercadoLivreSimulacao.Lib.Models;
namespace MercadoLivreSimulacao.Api.DTOs
{
    public class ProdutoDTO
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdVendedor { get; set; }



        public virtual Vendedor Vendedor { get; set; }
        public List<ProdutoXPedido> ListaProdutosXPedidos { get; set; }
    }
}