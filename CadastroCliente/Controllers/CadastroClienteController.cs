using API.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route ("[controller]")]
    public class CadastroClienteController : ControllerBase
    {
        private readonly ICadastroClienteRepository _cadastroRepository;

        public CadastroClienteController(ICadastroClienteRepository cadastroRepository)
        {
            _cadastroRepository = cadastroRepository;
        }

        /// <summary>
        /// Consulta de Clientes
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetAll")]
        public async Task<ActionResult> Getdbclientes()
        {
            var dbclientes = await _cadastroRepository.Getdbclientes();
            return Ok(dbclientes);
        }

        /// <summary>
        /// Consulta de Cliente Por ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult> Getdbclientes(int id)
        {
            var dbclientes = await _cadastroRepository.GetCadastro(id);
            return Ok(dbclientes);
        }
    }
}
