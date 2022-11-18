using MediatR;
using Microsoft.AspNetCore.Mvc;
using Backend.Application.Commands.Customer;
using Backend.Application.Queries.Customer;
using System.Threading.Tasks;

namespace backend.API.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        public readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // Commands
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] InsertCustomerCommand command)
        {
            return await Result(command);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateCustomerCommand command)
        {
            return await Result(command);
        }

        [HttpGet("getbyname/{name}")]
        public async Task<IActionResult> Get(string name)
        {
            var query = new GetCustomerByNameQuery() { Name = name };

            return await Result(query);
        }

        [HttpDelete("{ra}")]
        public async Task<IActionResult> Delete(string id)
        {
            var command = new DeleteCustomerCommand() { Id = int.Parse(id) };

            return await Result(command);
        }

        private async Task<IActionResult> Result(IBaseRequest request)
        {
            try
            {
                var retorno = await _mediator.Send(request);

                return retorno == null ? NotFound("Register didn't found.") : Ok(retorno);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}