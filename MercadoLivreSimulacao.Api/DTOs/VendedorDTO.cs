using MercadoLivreSimulacao.Lib.Models;
namespace MercadoLivreSimulacao.Api.DTOs
{
    public class VendedorDTO
    {
        public int IdVendedor { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataCadastro { get; set; }


        public List<Produto> ListaProdutos { get; set; } = new List<Produto>();
    }
}