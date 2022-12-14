using MediatR;
using Backend.Application.Commands.Customer;
using Backend.Application.Service;
using Backend.Domain.Entities;

namespace Backend.Application.Handlers.Customer
{

    public class CustomerCommandHandler :
      IRequestHandler<InsertCustomerCommand, Backend.Domain.Entities.Customer>,
      IRequestHandler<UpdateCustomerCommand, bool>,
      IRequestHandler<DeleteCustomerCommand, bool>

    {
        private readonly CustomerService _service;

        public CustomerCommandHandler(CustomerService service)
        {
            _service = service;
        }

        public Task<Backend.Domain.Entities.Customer> Handle(InsertCustomerCommand command, CancellationToken cancellationToken)
        {
            return _service.Insert(command);
        }

        public Task<bool> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            return _service.Update(request);
        }

        public Task<bool> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => _service.Delete(request));
        }

    }
}