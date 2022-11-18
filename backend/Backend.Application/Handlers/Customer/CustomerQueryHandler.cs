using MediatR;
using Backend.Application.Queries.Customer;
using Backend.Application.Queries.ViewModel;
using Backend.Application.Service;

namespace Backend.Application.Handlers.Customer
{
    public class CustomerQueryHandler :
      IRequestHandler<GetCustomerByNameQuery, CustomerViewModel>
    {
        private readonly CustomerService _service;

        public CustomerQueryHandler(CustomerService service)
        {
            _service = service;
        }

        public async Task<CustomerViewModel> Handle(GetCustomerByNameQuery request, CancellationToken cancellationToken)
        {
            return await _service.GetByName(request);
        }
    }
}