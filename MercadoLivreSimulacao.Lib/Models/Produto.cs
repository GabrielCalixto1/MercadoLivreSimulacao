namespace MercadoLivreSimulacao.Lib.Models
{
    public class Produto : ModelBase
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public int IdVendedor { get; set; }



        public virtual Vendedor Vendedor { get; set; }
        public List<ProdutoXPedido> ListaProdutosXPedidos { get; set; }

        public Produto(int idProduto, int idVendedor, string nome, string descricao, double valor, DateTime dataCadastro)
        {
            IdProduto = idProduto;
            Nome = nome;
            Descricao = descricao;
            SetValor(valor);
            SetData(dataCadastro);
        }
        public void SetValor(double valor)
        {
            ValorProdutoDeveSerMaiorQueZero(valor);
        }
        public void SetData(DateTime dataProduto)
        {
            if (DataEMenorQueDataAtual(dataProduto))
            {
                DataCadastro = dataProduto;
            }
        }

        public void ValorProdutoDeveSerMaiorQueZero(double valor)
        {
            if (valor > 0)
            {
                Valor = valor;
            }

        }
    }
}