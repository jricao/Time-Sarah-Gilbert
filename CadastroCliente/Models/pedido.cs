using System.Collections.Generic;

namespace CadastroCliente.Models
    {
    public class pedido
        {
        private string numeroPedido;
        public int Id { get; set; }
        public int ClienteID { get; set; }
        public int NumeroPedido { get; set; }
        public System.DateTime DataCompra { get; set; }

        public System.DateTime DataEntrega { get; set; }
        public decimal ValorTotal { get; set; }
        public List <PedidoItens>Itens {get;set;}


        }
    }
