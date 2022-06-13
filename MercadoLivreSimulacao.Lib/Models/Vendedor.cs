namespace MercadoLivreSimulacao.Lib.Models
{
    public class Vendedor : ModelBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataCadastro { get; set; }


        public List<Produto> ListaProdutos { get; set; } = new List<Produto>();

        public Vendedor(int idVendedor, string nome, string email, string cnpj, DateTime dataCadastro)  : base(idVendedor)
        {
 
            Nome = nome;
            SetEmail(email);
            Cnpj = cnpj;
            DataCadastro = dataCadastro;
        }
        public void SetEmail(string email)
        {
            if(EmailContemArroba(email))
            {
                Email = email;
            }
        }

    }
}