using FluentValidation;

namespace Backend.Application.Commands.Customer.Validators
{
    public class DeleteCustomerCommandValidator : AbstractValidator<DeleteCustomerCommand>
    {
        public DeleteCustomerCommandValidator()
        {
            RuleFor(c => c.Id)
              .NotEmpty()
                .WithMessage("The id must be informed");
        }

    }
}