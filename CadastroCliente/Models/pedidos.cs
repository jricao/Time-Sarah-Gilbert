namespace CadastroCliente.Models
    {
    public class pedidos
        {
        private string numeroPedido;
        public int Id { get; set; }
        public string ClienteID { get; set; }
        public string NumeroPedido { get => numeroPedido; set => numeroPedido = value; }
        public System.DateTime DataCompra { get; set; }

        public System.DateTime DataEntrega { get; set; }
        public string ValorTotal { get; set; }


        }
    }
