using CadastroCliente.Entities;
using System.Threading.Tasks;

namespace CadastroCliente.Contracts
{
    public interface ICadastroRepository
    {
        public Task<Cadastro> Getdbclientes(int ID);
       

    }
}
