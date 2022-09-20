using CadastroCliente.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroCliente.Contracts
{
    public interface ICadastroRepository
    {
        public Task<IEnumerable<Cadastro>> Getdbclientes();
        public Task<Cadastro> GetCadastro(int ID);
    }
}
