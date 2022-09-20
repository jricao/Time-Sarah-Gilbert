using CadastroCliente.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CadastroCliente.Controllers
{
    [ApiController]
    [Route ("[controller]")]
    public class CadastroController : ControllerBase
    {
        private readonly ICadastroRepository _cadastroRepository;

        public CadastroController(ICadastroRepository cadastroRepository)
        {
            _cadastroRepository = cadastroRepository;
        }

        [HttpGet]
        public async Task<ActionResult> Getdbclientes()
        {
            var dbclientes = await _cadastroRepository.Getdbclientes();
            return Ok(dbclientes);
        }

        [HttpGet("ID")]
        public async Task<ActionResult> Getdbclientes(int ID)
        {
            var dbclientes = await _cadastroRepository.GetCadastro(ID);
            return Ok(dbclientes);
        }
    }
}
