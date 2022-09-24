using CadastroCliente.Contracts;
using CadastroCliente.Models;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCliente.Repository
    {
    public class ProdutoRepository : IProdutoRepository
        {
        private readonly ProdutoContext _context;

        public ProdutoRepository(ProdutoContext context) => _context = context;

        public async Task<Produtos> GetCadastro(int ID)
            {
            var query = "Select ID, None, Descricao, PrecoUnitario, DataFabricacao, PrecoUnitario From db.produtos Where ID = @ID";

            using (var connection = _context.CreateConnection ())
                {
                var dbprodutos = await connection.QuerySingleAsync<Produtos> (query, new { ID });
                return dbprodutos;
                }
            }

        public async Task<IEnumerable<Produtos>> Getdbclientes( )
            {
            var query = "Select ID, None, Descricao, PrecoUnitario, DataFabricacao, PrecoUnitario From db.produtos";

            using (var connection = _context.CreateConnection ())
                {
                var dbprodutos = await connection.QueryAsync<Produtos> (query);
                return dbprodutos.ToList ();
                }
            }

        } }








        

  