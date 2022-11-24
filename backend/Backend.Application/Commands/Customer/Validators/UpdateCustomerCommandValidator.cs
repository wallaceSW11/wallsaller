using FluentValidation;

namespace Backend.Application.Commands.Customer.Validators
{
    public class UpdateCustomerCommandValidator : AbstractValidator<UpdateCustomerCommand>
    {
        public UpdateCustomerCommandValidator()
        {
            RuleFor(c => c.Id)
              .GreaterThanOrEqualTo(0)
                .WithMessage("The id is required");

            RuleFor(c => c.Name)
              .NotEmpty()
                .WithMessage("The name is required")
              .MaximumLength(100)
                .WithMessage("The name's maximum length its 100 characters");

            RuleFor(c => c.Identity)
              .NotEmpty()
                .WithMessage("The identity is required")
              .MaximumLength(14)
                .WithMessage("The identiy's maximum length its 14 characters without mask");

            RuleFor(c => c.Email)
              .NotEmpty()
                .WithMessage("The email is required")
              .MaximumLength(100)
                .WithMessage("The email's maximum length its 100 characters");
        }

    }
}