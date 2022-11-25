using FluentValidation.Results;
using MediatR;
using Backend.Application.Commands.Customer.Validators;
using Backend.Domain.Entities;

namespace Backend.Application.Commands.Customer
{
    public class InsertCustomerCommand : IRequest<Backend.Domain.Entities.Customer>
    {
        public string Name { get; set; }
        public string Identity { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }

        public void Validate(out ValidationResult validationResult)
        {
            validationResult = new InsertCustomerCommandValidator().Validate(this);
        }
    }
}