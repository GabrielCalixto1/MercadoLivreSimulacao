namespace MercadoLivreSimulacao.Lib.Models
{
    public class Transportadora
    {
        public int IdTransportadora { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Transportadora(int idTransportadora, string nome, string telefone, string email)
        {
            IdTransportadora = idTransportadora;
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }
}