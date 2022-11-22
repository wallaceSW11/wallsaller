using MediatR;
using Backend.Application.Commands.Customer;
using Backend.Application.Service;

namespace Backend.Application.Handlers.Customer
{

    public class CustomerCommandHandler :
      IRequestHandler<InsertCustomerCommand, bool>,
      IRequestHandler<UpdateCustomerCommand, bool>,
      IRequestHandler<DeleteCustomerCommand, bool>

    {
        private readonly CustomerService _service;

        public CustomerCommandHandler(CustomerService service)
        {
            _service = service;
        }

        public Task<bool> Handle(InsertCustomerCommand command, CancellationToken cancellationToken)
        {
            return _service.Insert(command);
        }

        public Task<bool> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => _service.Update(request));
        }

        public Task<bool> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => _service.Delete(request));
        }

    }
}