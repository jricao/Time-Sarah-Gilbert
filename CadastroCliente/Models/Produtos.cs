namespace CadastroCliente.Models
    {
    public class Produtos

        {
         public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Produtos(string descricao)
            {
            Descricao = descricao;
            }

        public decimal PrecoUnitario { get; set; }
        }
    }
