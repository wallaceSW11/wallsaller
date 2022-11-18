using FluentValidation;

namespace Backend.Application.Queries.Customer.Validators
{
    public class GetCustomerByNameQueryValidator : AbstractValidator<GetCustomerByNameQuery>
    {
        public GetCustomerByNameQueryValidator()
        {
            RuleFor(c => c.Name)
              .NotEmpty()
                .WithMessage("The name must be informed")
              .MaximumLength(100)
                .WithMessage("The name's maximum length its 100 characters");
        }

    }
}