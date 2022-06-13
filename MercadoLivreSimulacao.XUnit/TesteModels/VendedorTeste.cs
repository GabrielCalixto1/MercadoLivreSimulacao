using MercadoLivreSimulacao.Lib.Models;

namespace MercadoLivreSimulacao.XUnit.TesteModels
{
    public class VendedorTeste
    {

        [Fact]
        public void TesteSalvamentoEmail()
        {
            var emailEsperado = "testes@dodev.com";
            var transportadora = new Vendedor(2, "leandro", "testes@dodev.com", "259145000125", DateTime.Parse("01/01/2022"));
            var emailAtual = transportadora.Email;
            Assert.Equal(emailEsperado, emailAtual);
        }
    }
}