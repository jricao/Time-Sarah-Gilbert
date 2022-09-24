namespace CadastroCliente.Models
    {
    public class PedidoItens
        {
        private string NumeroPedido;

        public int Id { get; set; }
        public int PedidoID { get; set; }
        public int ProdutoID { get; set; }

        public int QuantidadeItens { get; set; }
        public decimal SubTotal { get; set; }

        }
    }
