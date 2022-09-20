using API.Context;
using API.Contracts;
using API.Entities;
using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace API.Repository
{
    public class CadastroClienteRepository : ICadastroClienteRepository
    {
        private readonly CadastroContext _context;

        public CadastroClienteRepository(CadastroContext context) => _context = context;

        public async Task<IEnumerable<Entities.CadastroCliente>> Getdbclientes()
        {
            var query = "Select ID, Name, Endereco, Telefone, Email, CPF From dbclientes";

            using (var connection = _context.CreateConnection())
            {
                var dbclientes = await connection.QueryAsync<CadastroCliente>(query);
                return dbclientes.ToList();
            }
        }

        public async Task<Entities.CadastroCliente> GetCadastro(int ID)
        {
            var query = "Select ID, Nome, Endereco, Telefone, Email, CPF From dbclientes Where ID = @ID";

            using (var connection = _context.CreateConnection())
            {
                var Cadastro = await connection.QuerySingleAsync<CadastroCliente>(query, new { ID });
                return Cadastro;  
            }

        }
    }
}
