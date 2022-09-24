using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroCliente.Contracts
    {
     public interface IProdutoRepository
        {
        public Task<IEnumerable<Models.Produtos>> Getdbclientes( );
        public Task<Models.Produtos> GetCadastro(int ID);
        }
    }
