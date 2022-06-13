using MercadoLivreSimulacao.Lib.Models;
namespace MercadoLivreSimulacao.XUnit.TesteModels
{
    public class PedidoTeste
    {
        [Fact]
        public void TesteSalvamentoData()
        {
            var dataPedidoEsperado = DateTime.Parse("01/01/2022");
            var pedido = new Pedido(1, 1, 1, dataPedidoEsperado, "Confirmado");
            var dataPedidoAtual = pedido.DataPedido;
            Assert.Equal(dataPedidoEsperado, dataPedidoAtual);
        }
        [Fact]
        public void TesteSalvementoStatusPedido()
        {
            var statusPedidoEsperado = "Entregue";
            var pedido = new Pedido(1, 1, 1, DateTime.Parse("04/04/2022"), statusPedidoEsperado);
            var statusPedidoAtual = pedido.StatusPedido;
            Assert.Equal(statusPedidoEsperado, statusPedidoAtual);
        }
    }
}