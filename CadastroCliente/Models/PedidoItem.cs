namespace CadastroCliente.Models
    {
    public class PedidosItem
        {
        private string NumeroPedido;

        public int Id { get; set; }
        public string PedidoID { get; set; }
        public string ProdutoID { get => NumeroPedido; set => NumeroPedido = value; }

        public string QuantidadeItens { get; set; }
        public string SubTotal { get; set; }

        }
    }
