using FluentValidation;

namespace Backend.Application.Commands.Validators
{
    public class UpdateClientCommandValidator : AbstractValidator<UpdateClientCommand>
    {
        public UpdateClientCommandValidator()
        {
            RuleFor(c => c.Name)
              .NotEmpty()
                .WithMessage("The name must be informed")
              .MaximumLength(100)
                .WithMessage("The name's maximum length its 100 characters");
        }

    }
}