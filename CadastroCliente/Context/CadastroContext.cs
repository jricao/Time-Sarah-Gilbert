using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace CadastroCliente.Context
{
    public class CadastroContext
    {
        private readonly IConfiguration _config;
        private readonly string _connectionString;

        public CadastroContext(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("SqlConnection");
        }
        public IDbConnection CreateConnection() 
        {
            return new SqlConnection(_connectionString);
        }
    }
}
