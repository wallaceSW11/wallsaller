using FluentValidation;

namespace Backend.Application.Commands.Customer.Validators
{
    public class UpdateCustomerCommandValidator : AbstractValidator<UpdateCustomerCommand>
    {
        public UpdateCustomerCommandValidator()
        {
            RuleFor(c => c.Name)
              .NotEmpty()
                .WithMessage("The name must be informed")
              .MaximumLength(100)
                .WithMessage("The name's maximum length its 100 characters");
        }

    }
}