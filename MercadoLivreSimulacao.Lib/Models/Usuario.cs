namespace MercadoLivreSimulacao.Lib.Models
{
    public class Usuario : ModelBase
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; private set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Senha { get; private set; }


        public virtual List<Pedido> ListaPedidos { get; set; } = new List<Pedido>();

        public Usuario(int idUsuario, string nome, string email, string cpf, DateTime dataNascimento, string senha)
        {
            IdUsuario = idUsuario;
            Nome = nome;
            SetEmail(email);
            Cpf = cpf;
            DataNascimento = dataNascimento;
            SetSenha(senha);
        }
        public void SetEmail(string email)
        {
            if (EmailContemArroba(email))
            {
                Email = email;
            }
        }
        public void SetSenha(string senha)
        {
            if (SenhaTemMaisDeOitoOuMaisCaracteres(senha))
            {
                Senha = senha;
            }
        }
        public void SetCpf(string cpf)
        {
            if (CpfTemApenasNumero(cpf))
            {
                Cpf = cpf;
            }
        }
        public bool SenhaTemMaisDeOitoOuMaisCaracteres(string senha)
        {
            if (senha.Length >= 8)
            {
                return true;
            }
            return false;
        }
        public bool CpfTemApenasNumero(string cpf)
        {
            {
                if (cpf.Where(x => char.IsLetter(x)).Count() > 0)
                    return false;
            }
            return true;
        }
    }
}