using FluentValidation;

namespace Backend.Application.Queries.Customer.Validators
{
    public class GetCustomerByIdQueryValidator : AbstractValidator<GetCustomerByIdQuery>
    {
        public GetCustomerByIdQueryValidator()
        {
            RuleFor(c => c.Id)
              .NotEmpty()
                .WithMessage("The id must be informed")
              .MaximumLength(100)
                .WithMessage("The name's maximum length its 100 characters");
        }

    }
}