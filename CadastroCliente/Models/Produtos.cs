using System;

namespace CadastroCliente.Models
    {
    public class Produtos

        {
        private DateTime dataFabricação;

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string PreçoUnitario { get; set; }
        public System.DateTime DataFabricação { get => dataFabricação; set => dataFabricação = value; }
        public string Garantia { get; set; }
        }




    }
