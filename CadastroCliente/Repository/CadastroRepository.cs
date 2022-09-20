using CadastroCliente.Context;
using CadastroCliente.Contracts;
using CadastroCliente.Entities;
using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace CadastroCliente.Repository
{
    public class CadastroRepository : ICadastroRepository
    {
        private readonly CadastroContext _context;

        public CadastroRepository(CadastroContext context) => _context = context;

        public async Task<IEnumerable<Cadastro>> Getdbclientes()
        {
            var query = "Select ID, Name, Endereco, Telefone, Email, CPF From dbclientes";

            using (var connection = _context.CreateConnection())
            {
                var dbclientes = await connection.QueryAsync<Cadastro>(query);
                return dbclientes.ToList();
            }
        }

        public async Task<Cadastro> GetCadastro(int ID)
        {
            var query = "Select ID, Nome, Endereco, Telefone, Email, CPF From dbclientes Where ID = @ID";

            using (var connection = _context.CreateConnection())
            {
                var Cadastro = await connection.QuerySingleAsync<Cadastro>(query, new { ID });
                return Cadastro;  
            }

        }
    }
}
