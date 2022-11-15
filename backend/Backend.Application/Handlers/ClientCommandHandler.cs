using MediatR;
using Backend.Application.Commands;
using Backend.Application.Service;

namespace Backend.Application.Handlers
{

    public class ClientCommandHandler :
      IRequestHandler<InsertClientCommand, bool>
    {
        private readonly ClientService _service;

        public ClientCommandHandler(ClientService service)
        {
            _service = service;
        }

        public Task<bool> Handle(InsertClientCommand command, CancellationToken cancellationToken)
        {
            return _service.Insert(command);
        }

    }
}