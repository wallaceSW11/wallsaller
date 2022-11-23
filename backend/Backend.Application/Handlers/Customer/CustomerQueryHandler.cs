using MediatR;
using Backend.Application.Queries.Customer;
using Backend.Application.Queries.ViewModel;
using Backend.Domain.Entities;
using Backend.Application.Service;

namespace Backend.Application.Handlers.Customer
{
    public class CustomerQueryHandler :
      IRequestHandler<GetCustomerByNameQuery, CustomerViewModel>,
      IRequestHandler<GetCustomerByIdQuery, CustomerViewModel>,
      IRequestHandler<GetCustomers, IEnumerable<Backend.Domain.Entities.Customer>>
    {
        private readonly CustomerService _service;

        public CustomerQueryHandler(CustomerService service)
        {
            _service = service;
        }

        public async Task<CustomerViewModel> Handle(GetCustomerByNameQuery query, CancellationToken cancellationToken)
        {
            return await _service.GetByName(query);
        }

        public async Task<CustomerViewModel> Handle(GetCustomerByIdQuery query, CancellationToken cancellationToken)
        {
            return await _service.GetById(query);
        }

        public async Task<IEnumerable<Backend.Domain.Entities.Customer>> Handle(GetCustomers query, CancellationToken cancellationToken)
        {
            return await _service.GetAll();
        }
    }
}