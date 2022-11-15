using FluentValidation;

namespace Backend.Domain.Entities
{
    public class ClientValidator : AbstractValidator<Client>
    {
        internal ClientValidator()
        {
            RuleFor(c => c.Name)
              .NotEmpty()
                .WithMessage("The name must be informed")
              .MaximumLength(100)
                .WithMessage("The name's maximum length its 100 characters");

        }
    }
}