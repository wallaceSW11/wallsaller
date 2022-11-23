using FluentValidation.Results;
using MediatR;
using Backend.Application.Queries.Customer.Validators;
using Backend.Application.Queries.ViewModel;

namespace Backend.Application.Queries.Customer
{
    public class GetCustomerByIdQuery : IRequest<CustomerViewModel>
    {
        public string Id { get; set; }

        public void Validate(out ValidationResult validationResult)
        {
            validationResult = new GetCustomerByIdQueryValidator().Validate(this);
        }
    }
}