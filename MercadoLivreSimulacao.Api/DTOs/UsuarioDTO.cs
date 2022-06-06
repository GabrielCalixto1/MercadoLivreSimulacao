using MercadoLivreSimulacao.Lib.Models;
namespace MercadoLivreSimulacao.Api.DTOs
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Senha { get; set; }


        public virtual List<Pedido> ListaPedidos { get; set; } = new List<Pedido>();
    }
}