using FluentValidation.Results;
using MediatR;
using Backend.Application.Queries.Customer.Validators;
using Backend.Application.Queries.ViewModel;

namespace Backend.Application.Queries.Customer
{
    public class GetCustomerByNameQuery : IRequest<CustomerViewModel>
    {
        public string Name { get; set; }

        public void Validate(out ValidationResult validationResult)
        {
            validationResult = new GetCustomerByNameQueryValidator().Validate(this);
        }
    }
}