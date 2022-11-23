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

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var command = new DeleteCustomerCommand() { Id = int.Parse(id) };

            return await Result(command);
        }


        // queries
        [HttpGet("getbyname/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var query = new GetCustomerByNameQuery() { Name = name };

            return await Result(query);
        }

        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var query = new GetCustomerByIdQuery() { Id = id.ToString() };

            return await Result(query);
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAall()
        {
            var query = new GetCustomers();

            return await Result(query);
        }


    }
}