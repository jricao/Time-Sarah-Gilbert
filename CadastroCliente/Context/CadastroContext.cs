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
            _connectionString = _config.GetConnectionString("Sqlconnections");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
