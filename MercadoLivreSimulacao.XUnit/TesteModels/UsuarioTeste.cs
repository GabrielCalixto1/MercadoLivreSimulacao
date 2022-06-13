using MercadoLivreSimulacao.Lib.Models;

namespace MercadoLivreSimulacao.XUnit.TesteModels
{
    public class UsuarioTeste
    {
        /* public void SetEmail(string email)
          public void SetSenha(string senha)
          public void SetCpf(string cpf)*/
        [Fact]
        public void TesteSalvamentoEmail()
        {
            var emailEsperado = "testes@dodev.com";
            var usuario = new Usuario(2, "Gabriel", emailEsperado, "10663332635", DateTime.Parse("05/05/2000"), "8849481414");
            var emailAtual = usuario.Email;
            Assert.Equal(emailEsperado, emailAtual);
        }
        [Fact]
        public void TesteSalvementoCpf()
        {
            var cpfEsperado = "10663332635";
            var usuario = new Usuario(2, "Gabriel", "testes@dodev.com", cpfEsperado, DateTime.Parse("05/05/2000"), "8849481414");
            var cpfAtual = usuario.Cpf;
            Assert.Equal(cpfEsperado, cpfAtual);
        }
        [Fact]
        public void TesteSalvementoSenha()
        {
            var senhaEsperada = "8849481414";
            var usuario = new Usuario(2, "Gabriel", "testes@dodev.com", "10663332635", DateTime.Parse("05/05/2000"), senhaEsperada);
            var senhaAtual = usuario.Senha;
            Assert.Equal(senhaEsperada, senhaAtual);
        }


    }
}