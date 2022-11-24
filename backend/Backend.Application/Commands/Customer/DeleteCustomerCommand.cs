using FluentValidation.Results;
using MediatR;
using Backend.Application.Commands.Customer.Validators;

namespace Backend.Application.Commands.Customer
{
    public class DeleteCustomerCommand : IRequest<bool>
    {
        public string Id { get; set; }

        public void Validate(out ValidationResult validationResult)
        {
            validationResult = new DeleteCustomerCommandValidator().Validate(this);
        }
    }
}