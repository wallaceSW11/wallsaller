using FluentValidation;

namespace Backend.Application.Queries.Validators
{
    public class GetClientByNameQueryValidator : AbstractValidator<GetClientByNameQuery>
    {
        public GetClientByNameQueryValidator()
        {
            RuleFor(c => c.Name)
              .NotEmpty()
                .WithMessage("The name must be informed")
              .MaximumLength(100)
                .WithMessage("The name's maximum length its 100 characters");
        }

    }
}