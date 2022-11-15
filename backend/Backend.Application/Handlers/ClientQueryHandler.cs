using MediatR;
using Backend.Application.Queries;
using Backend.Application.Queries.ViewModel;
using Backend.Application.Service;

namespace Backend.Application.Handlers
{
    public class ClientQueryHandler :
      IRequestHandler<GetClientByNameQuery, ClientViewModel>
    {
        private readonly ClientService _service;

        public ClientQueryHandler(ClientService service)
        {
            _service = service;
        }

        public async Task<ClientViewModel> Handle(GetClientByNameQuery request, CancellationToken cancellationToken)
        {
            return await _service.GetByName(request);
        }
    }
}