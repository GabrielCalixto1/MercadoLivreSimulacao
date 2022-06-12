namespace MercadoLivreSimulacao.Lib.Models
{
    public class Transportadora : ModelBase
    {
        public int IdTransportadora { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }


        public List<Pedido> ListaPedidos { get; set; } = new List<Pedido>();

        public Transportadora(int idTransportadora, string nome, string telefone, string email)
        {
            IdTransportadora = idTransportadora;
            Nome = nome;
            SetTelefone(telefone);
            SetEmail(email);
        }
        public void SetEmail(string email)
        {
            if (EmailContemArroba(email))
            {
                Email = email;
            }

        }
        public void SetTelefone(string telefone)
        {
            if (TelefoneTemEntreDezEOnzeCaracteres(telefone))
            {
                Telefone = telefone;
            }
        }
        public bool TelefoneTemEntreDezEOnzeCaracteres(string telefone)
        {
            if (telefone.Length >= 10 && telefone.Length <= 11)
            {
                return true;
            }
            return false;
        }
    }
}