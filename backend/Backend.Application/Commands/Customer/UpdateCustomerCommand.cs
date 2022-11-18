using FluentValidation.Results;
using MediatR;
using Backend.Application.Commands.Customer.Validators;

namespace Backend.Application.Commands.Customer
{
    public class UpdateCustomerCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public void Validate(out ValidationResult validationResult)
        {
            validationResult = new UpdateCustomerCommandValidator().Validate(this);
        }
    }
}