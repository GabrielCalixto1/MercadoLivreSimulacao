using MercadoLivreSimulacao.Lib.Models;

namespace MercadoLivreSimulacao.XUnit.TesteModels
{
    public class ProdutoTeste
    {
                [Fact]
        public void TesteSalvamentoValor()
        {
            var valorEsperado = 500;
            var produto = new Produto(2,2,"carlos","Novo", valorEsperado, DateTime.Parse("04/04/2022"));
            var valorAtual = produto.Valor;
            Assert.Equal(valorEsperado, valorAtual);
        }
        [Fact]
        public void TesteSalvementoData()
        {
            var dataEsperada = DateTime.Parse("04/04/2022");
            var produto = new Produto(2,2,"carlos","Novo", 500, dataEsperada);
            var dataAtual = produto.DataCadastro;
            Assert.Equal(dataEsperada, dataAtual);
        }

    }
}