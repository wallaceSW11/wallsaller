using FluentValidation;

namespace Backend.Domain.Entities
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        internal CustomerValidator()
        {
            RuleFor(c => c.Name)
              .NotEmpty()
                .WithMessage("The name must be informed")
              .MaximumLength(100)
                .WithMessage("The name's maximum length its 100 characters");

            RuleFor(c => c.Identity)
              .NotEmpty()
                .WithMessage("The identity must be informed")
              .MaximumLength(14)
                .WithMessage("The identity's maximum length its 14 characters");

            RuleFor(c => c.Email)
              .NotEmpty()
                .WithMessage("The email must be informed")
              .MaximumLength(100)
                .WithMessage("The email's maximum length its 100 characters");

        }
    }
}