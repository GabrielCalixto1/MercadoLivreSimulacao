namespace MercadoLivreSimulacao.Lib.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public int IdVendedor { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public Produto(int idProduto, int idVendedor, string nome, string descricao, double valor, DateTime dataCadastro)
        {
            IdProduto = idProduto;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            DataCadastro = dataCadastro;
        }
    }
}