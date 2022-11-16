using MediatR;
using Microsoft.AspNetCore.Mvc;
using Backend.Application.Commands;
using Backend.Application.Queries;
using System.Threading.Tasks;

namespace backend.API.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        public readonly IMediator _mediator;

        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // Commands
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] InsertClientCommand command)
        {
            return await Result(command);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateClientCommand command)
        {
            return await Result(command);
        }

        [HttpGet]
        [Route("name")]
        public async Task<IActionResult> Get([FromQuery] GetClientByNameQuery query)
        {
            return await Result(query);
        }

        [HttpDelete("{ra}")]
        public async Task<IActionResult> Delete(string id)
        {
            var command = new DeleteClientCommand() { Id = int.Parse(id) };

            return await Result(command);
        }

        private async Task<IActionResult> Result(IBaseRequest request)
        {
            try
            {
                var retorno = await _mediator.Send(request);

                return retorno == null ? NotFound("Registro não encontrado") : Ok(retorno);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}