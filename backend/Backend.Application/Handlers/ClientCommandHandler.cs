using MediatR;
using Backend.Application.Commands;
using Backend.Application.Service;

namespace Backend.Application.Handlers
{

    public class ClientCommandHandler :
      IRequestHandler<InsertClientCommand, bool>,
      IRequestHandler<UpdateClientCommand, bool>,
      IRequestHandler<DeleteClientCommand, bool>

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

        public Task<bool> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => _service.Update(request));
        }

        public Task<bool> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => _service.Delete(request));
        }

    }
}