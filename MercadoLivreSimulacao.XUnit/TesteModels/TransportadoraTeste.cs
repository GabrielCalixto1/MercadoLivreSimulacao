using MercadoLivreSimulacao.Lib.Models;

namespace MercadoLivreSimulacao.XUnit.TesteModels
{
    public class TransportadoraTeste
    {
        [Fact]
        public void TesteSalvamentoEmail()
        {
            var emailEsperado = "testes@dodev.com";
            var transportadora = new Transportadora(2, "Sedex", "9999681738", emailEsperado);
            var emailAtual = transportadora.Email;
            Assert.Equal(emailEsperado, emailAtual);
        }
        [Fact]
        public void TesteSalvementoTelefone()
        {
            var telefoneEsperado = "9999681738";
            var transportadora = new Transportadora(2, "Sedex", telefoneEsperado, "testes@dodev.com");
            var telefoneAtual = transportadora.Telefone;
            Assert.Equal(telefoneEsperado, telefoneAtual);
        }
    }
}