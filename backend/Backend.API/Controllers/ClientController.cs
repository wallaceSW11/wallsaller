using MediatR;
using Microsoft.AspNetCore.Mvc;

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


        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Wall");
        }
    }
}