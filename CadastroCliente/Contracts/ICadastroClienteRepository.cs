using API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Contracts
{
    public interface ICadastroClienteRepository
    {
        public Task<IEnumerable<Entities.CadastroCliente>> Getdbclientes();
        public Task<Entities.CadastroCliente> GetCadastro(int ID);
    }
}
